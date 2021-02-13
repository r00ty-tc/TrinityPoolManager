using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using DBFileReaderLib;
using MySql.Data.MySqlClient;
using Trinity.PoolManagerData;

namespace Trinity.PoolDB
{
    public delegate void PoolLoadStatusEventHandler(object sender, PoolLoadStatus e);
    public class PoolLoadStatus
    {
        public string currentStatus;
        public uint currentItem;
        public uint maxItems;
    }
    
    public partial class PoolDB
    {
        private static readonly (string dbcName, string luaName)[] WowheadZoneLookup =
        {
            ("Ashenvale", "ASHENVALE"),
            ("Aszhara", "AZSHARA"),
            ("AzuremystIsle", "AZUREMYST_ISLE"),
            ("Barrens", "BARRENS"),
            ("BloodmystIsle", "BLOODMYST_ISLE"),
            ("Darkshore", "DARKSHORE"),
            ("Darnassis", "DARNASSUS"),
            ("Desolace", "DESOLACE"),
            ("Durotar", "DUROTAR"),
            ("Dustwallow", "DUSTWALLOW_MARSH"),
            ("Felwood", "FELWOOD"),
            ("Feralas", "FERALAS"),
            ("Moonglade", "MOONGLADE"),
            ("Mulgore", "MULGORE"),
            ("Ogrimmar", "ORGRIMMAR"),
            ("Silithus", "SILITHUS"),
            ("StonetalonMountains", "STONETALON_MOUNTAINS"),
            ("Tanaris", "TANARIS"),
            ("Teldrassil", "TELDRASSIL"),
            ("TheExodar", "EXODAR"),
            ("ThousandNeedles", "THOUSAND_NEEDLES"),
            ("ThunderBluff", "THUNDER_BLUFF"),
            ("UngoroCrater", "UNGORO_CRATER"),
            ("Winterspring", "WINTERSPRING"),
            ("Alterac", "ALTERAC_MOUNTAINS"),
            ("Arathi", "ARATHI_HIGHLANDS"),
            ("Badlands", "BADLANDS"),
            ("BlastedLands", "BLASTED_LANDS"),
            ("BurningSteppes", "BURNING_STEPPES"),
            ("DeadwindPass", "DEADWIND_PASS"),
            ("DunMorogh", "DUN_MOROGH"),
            ("Duskwood", "DUSKWOOD"),
            ("EasternPlaguelands", "EASTERN_PLAGUELANDS"),
            ("Elwynn", "ELWYNN_FOREST"),
            ("EversongWoods", "EVERSONG_WOODS"),
            ("Ghostlands", "GHOSTLANDS"),
            ("Hilsbrad", "HILLSBRAD_FOOTHILLS"),
            ("Hinterlands", "HINTERLANDS"),
            ("Ironforge", "IRONFORGE"),
            ("LochModan", "LOCH_MODAN"),
            ("Redridge", "REDRIDGE_MOUNTAINS"),
            ("SearingGorge", "SEARING_GORGE"),
            ("SilvermoonCity", "SILVERMOON"),
            ("Silverpine", "SILVERPINE_FOREST"),
            ("Stormwind", "STORMWIND_CITY"),
            ("Stranglethorn", "STRANGLETHORN_VALE"),
            ("Sunwell", "QUEL_DANAS"),
            ("SwampOfSorrows", "SWAMP_OF_SORROWS"),
            ("Tirisfal", "TIRISFAL_GLADES"),
            ("Undercity", "UNDERCITY"),
            ("WesternPlaguelands", "WESTERN_PLAGUELANDS"),
            ("Westfall", "WESTFALL"),
            ("Wetlands", "WETLANDS"),
            ("BladesEdgeMountains", "BLADES_EDGE_MOUNTAINS"),
            ("Hellfire", "HELLFIRE_PENINSULA"),
            ("Nagrand", "NAGRAND"),
            ("Netherstorm", "NETHERSTORM"),
            ("ShadowmoonValley", "SHADOWMOON_VALLEY"),
            ("ShattrathCity", "SHATTRATH"),
            ("TerokkarForest", "TEROKKAR_FOREST"),
            ("Zangarmarsh", "ZANGARMARSH"),
            ("BoreanTundra", "BOREAN_TUNDRA"),
            ("CrystalsongForest", "CRYSTALSONG_FOREST"),
            ("Dalaran", "DALARAN"),
            ("Dragonblight", "DRAGONBLIGHT"),
            ("GrizzlyHills", "GRIZZLY_HILLS"),
            ("HrothgarsLanding", "HROTHGARS_LANDING"),
            ("HowlingFjord", "HOWLING_FJORD"),
            ("IcecrownGlacier", "ICECROWN_GLACIER"),
            ("SholazarBasin", "SHOLAZAR_BASIN"),
            ("TheStormPeaks", "STORM_PEAKS"),
            ("LakeWintergrasp", "LAKE_WINTERGRASP"),
            ("ZulDrak", "ZULDRAK"),
        };

        public static readonly int MAX_SEARCH_DISTANCE = 13;    // This equates to 0.2 in zoneXY terms

        public static string GetLuaZone(string luaZone) =>
            WowheadZoneLookup.FirstOrDefault(row => row.luaName.Equals(luaZone)).dbcName;

        private readonly MySqlConnection sqlConnection;
        private SortedDictionary<uint, TrinityObject> creatureData;
        private SortedDictionary<uint, TrinityObject> gameObjectData;
        private SortedDictionary<uint, TrinityObjectTemplate> creatureTemplateData;
        private SortedDictionary<uint, TrinityObjectTemplate> gameObjectTemplateData;
        private SortedDictionary<uint, LegacyPoolEntry> legacyPoolData;
        private SortedDictionary<uint, MapPoolItem> mapPoolData;
        private SortedDictionary<string, List<TrinityObjectTemplate>> goTemplateByName;
        private Dictionary<uint, LegacyPoolEntry> unstructLegacyPoolData;
        private PoolLoadStatus currentStatus;
        private ReaderWriterLockSlim statusLock;
        private Storage<MapEntry> dbcMap;
        private Storage<AreaTableEntry> dbcArea;
        private Storage<WorldMapAreaEntry> dbcWMArea;
        private Dictionary<int, AreaTableEntry> dbcZone;
        private Dictionary<uint, WorldMapAreaEntry> dbcWMZoneByID;
        private WowheadDBStore wowheadStore;
        private ConfigData configData;

        private bool poolsLoaded;

        public SortedDictionary<uint, TrinityObject> CreatureData => creatureData;
        public SortedDictionary<uint, TrinityObjectTemplate> CreatureTemplateData => creatureTemplateData;
        public SortedDictionary<uint, TrinityObject> GameObjectData => gameObjectData;
        public SortedDictionary<uint, TrinityObjectTemplate> GameObjectTemplateData => gameObjectTemplateData;
        public SortedDictionary<string, List<TrinityObjectTemplate>> GameObjectTemplatesByName => goTemplateByName;
        public SortedDictionary<uint, LegacyPoolEntry> LegacyPoolData => legacyPoolData;
        public WowheadDBStore WowheadData => wowheadStore;

        public PoolDB(ConfigData config)
        {
            configData = config;
            creatureData = null;
            gameObjectData = null;
            legacyPoolData = null;
            unstructLegacyPoolData = null;
            mapPoolData = null;
            wowheadStore = null;
            goTemplateByName = null;
            currentStatus = new PoolLoadStatus();
            statusLock = new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

            var builder = new MySqlConnectionStringBuilder
            {
                Server = configData.SqlServerHost,
                UserID = configData.SqlServerUser,
                Password = configData.SqlServerPass,
                Database = configData.SqlServerDB
            };
            sqlConnection = new MySqlConnection(builder.ToString());
            sqlConnection.Open();

        }

        public static string[] GetDatabases(string serverName, string userName, string passWord)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = serverName,
                UserID = userName,
                Password = passWord,
            };
            var returnValue = new List<string>();
            using (var tempConnection = new MySqlConnection(builder.ToString()))
            {
                tempConnection.Open();
                var dbListQuery = "SHOW DATABASES";
                using (var dbListCmd = new MySqlCommand(dbListQuery, tempConnection))
                    using (var dbListRecords = dbListCmd.ExecuteReader())
                        while (dbListRecords.Read())
                            returnValue.Add(dbListRecords.GetString(0));
                tempConnection.Close();
                return returnValue.ToArray();
            }
        }

        ~PoolDB()
        {
            if (sqlConnection.State != ConnectionState.Broken && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            sqlConnection.Dispose();
        }

        public PoolLoadStatus GetStatus()
        {
            statusLock.EnterReadLock();
            var returnStatus = new PoolLoadStatus()
            {
                currentStatus = currentStatus.currentStatus,
                currentItem = currentStatus.currentItem,
                maxItems = currentStatus.maxItems
            };
            statusLock.ExitReadLock();
            return returnStatus;

        }

        private void UpdateStatus(string statusText = null, uint? currentItem = null, uint? maxItems = null)
        {
            // We don't want to bother updating if this is locked by the reader unless updating text or max items
            if (statusLock.TryEnterWriteLock((statusText == null && maxItems == null) ? 0 : 100))
            {
                if (statusText != null)
                    currentStatus.currentStatus = statusText;

                if (currentItem.HasValue)
                    currentStatus.currentItem = currentItem.Value;

                if (maxItems.HasValue)
                    currentStatus.maxItems = maxItems.Value;
                statusLock.ExitWriteLock();
            }

            //statusHandler(this, currentStatus);
        }

        public void LoadData()
        {
            // Load DBC files
            dbcMap = new Storage<MapEntry>($"{configData.DbcFolder}Map.dbc");
            dbcArea = new Storage<AreaTableEntry>($"{configData.DbcFolder}AreaTable.dbc");
            dbcZone = dbcArea.Where(row => row.Value.ParentAreaID == 0).ToDictionary(row => row.Key, row => row.Value);
            dbcWMArea = new Storage<WorldMapAreaEntry>($"{configData.DbcFolder}WorldMapArea.dbc");
            dbcWMZoneByID = dbcWMArea.Where(row => dbcZone.Values.Select(zone => zone.ID).Contains((int) row.Value.AreaID)).
                ToDictionary(wmRow => wmRow.Value.AreaID, wmRow => wmRow.Value);

            // Load all data into internal structures
            currentStatus.maxItems = getTotalRows();
            currentStatus.currentItem = 0;
            loadCreatures();
            loadGameObjects();
            loadLegacyPools();
            poolsLoaded = loadPools();
            // Load wowhead
            wowheadStore = loadWowhead(configData.WowheadDBFile);

            UpdateStatus($"Loading complete", 1, 1);
        }

        public bool IsLoaded => (dbcMap != null && dbcZone != null && dbcArea != null && creatureTemplateData != null &&
                                 creatureData != null && gameObjectData != null && gameObjectTemplateData != null);

        private WowheadDBStore loadWowhead(string filename)
        {
            var lines = File.ReadAllLines(filename);
            var mode = 0;   // Search for zone
            WowheadZoneData currentZone = null;
            uint currentEntry = 0;
            var wowhead = new WowheadDBStore();
            var zoneRegex = new Regex(@"\s*([A-Z_]+)\s\=\ \{");
            var entryRegex = new Regex(@"\s*\[(\d+)\]\ \=\ \{");
            var nodeRegex = new Regex(@"\s*([0-9]{5,6},.*)");
            foreach (var line in lines)
            {
                Match zoneMatch = zoneRegex.Match(line);
                if (zoneMatch.Success && zoneMatch.Groups.Count > 1)
                {
                    var zoneName = zoneMatch.Groups[1].Value;
                    var zone = getDbcZoneByLuaName(zoneName);
                    var wmzone = dbcWMZoneByID[(uint)zone.ID];
                    var map = dbcMap[zone.ContinentID];
                    currentZone = wowhead.AddZone(zone.ID, zone, wmzone, map);
                }
                else
                {
                    Match entryMatch = entryRegex.Match(line);
                    if (entryMatch.Success && entryMatch.Groups.Count > 1)
                    {
                        currentEntry = Convert.ToUInt32(entryMatch.Groups[1].Value);
                        if (gameObjectTemplateData.TryGetValue(currentEntry, out var gameObjectTemplate))
                            currentZone.AddEntry(gameObjectTemplate);
                        else
                            currentEntry = 0;
                    }
                    else
                    {
                        if (currentEntry != 0)
                        {
                            Match nodeMatch = nodeRegex.Match(line);
                            if (nodeMatch.Success && nodeMatch.Groups.Count > 1)
                            {
                                bool first = true;
                                foreach (Group group in nodeMatch.Groups)
                                {
                                    if (!first)
                                        currentZone.AddNodes(currentEntry, group.Value);
                                    else
                                        first = false;
                                }
                            }
                        }
                    }
                }
            }
            wowhead.MarkPresentObjects(goTemplateByName);
            return wowhead;
        }

        public IEnumerable<TrinityObjectTemplate> GetGameObjectsByName(string goName)
        {
            if (!goTemplateByName.TryGetValue(goName, out List<TrinityObjectTemplate> goTemplate))
                return null;

            return goTemplate;
        }

        private AreaTableEntry getDbcZoneByLuaName(string luaName)
        {
            var dbcName = GetLuaZone(luaName);
            var tempzone = dbcWMArea.Values.FirstOrDefault(row => row.AreaName.Equals(dbcName, StringComparison.InvariantCultureIgnoreCase));
            var zone = tempzone != null ? dbcZone[(int)tempzone.AreaID] : null;
            return zone;
        }

        private WorldMapAreaEntry getWMZoneByLuaName(string luaName)
        {
            var dbcName = GetLuaZone(luaName);
            var zone = dbcWMArea.Values.FirstOrDefault(row => row.AreaName.Equals(dbcName, StringComparison.InvariantCultureIgnoreCase));
            return zone;
        }
    }
}
