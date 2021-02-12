using System;
using System.Collections.Generic;
using System.Linq;
using Trinity.PoolManagerData;

namespace Trinity.PoolDB
{
    public class WowheadDBStore
    {
        public Dictionary<int, WowheadZoneData> zoneData;

        public WowheadDBStore()
        {
            zoneData = new Dictionary<int, WowheadZoneData>();
        }

        public void MarkPresentObjects(SortedDictionary<uint, TrinityObjectTemplate> objects)
        {
            foreach (var zone in zoneData.Values)
            {
                foreach (var entry in zone.GetEntries())
                {
                    if (objects.TryGetValue(entry, out var entryObjects))
                    {
                        foreach (var node in zone.GetNodes(entry))
                        {
                            var nearestObj = entryObjects.objects.OrderBy(row => node.getDist(row.positionX, row.positionY)).FirstOrDefault(row => node.getDist(row.positionX, row.positionY) < PoolDB.MAX_SEARCH_DISTANCE);
                            if (nearestObj != null)
                            {
                                node.inWorldDb = true;
                                node.NearestObject = nearestObj;
                            }
                        }
                    }
                }
            }
        }

        public WowheadZoneData AddZone(int zoneId, AreaTableEntry dbczone, WorldMapAreaEntry dbcwmzone, MapEntry dbcmap)
        {
            var zone = new WowheadZoneData(zoneId, dbczone, dbcwmzone, dbcmap);
            zoneData.Add(zoneId, zone);
            return zone;
        }

        public bool TryAddZone(int zoneId, AreaTableEntry dbczone, WorldMapAreaEntry dbcwmzone, out WowheadZoneData zonedata, MapEntry dbcmap)
        {
            if (!Contains(zoneId))
            {
                zonedata = null;
                return false;
            }

            zonedata = AddZone(zoneId, dbczone, dbcwmzone, dbcmap);
            return true;
        }

        public bool Contains(int zoneid) => zoneData.ContainsKey(zoneid);

        public WowheadZoneData GetZone(int zoneId)
        {
            return zoneData[zoneId];
        }

        public bool TryGetZone(int zoneId, out WowheadZoneData zonedata)
        {
            if (!Contains(zoneId))
            {
                zonedata = null;
                return false;
            }

            zonedata = GetZone(zoneId);
            return true;
        }

        public IEnumerable<WowheadZoneData> GetZones() => zoneData.Values.AsEnumerable();
    }

    public class WowheadZoneData
    {
        private int zoneId;
        public AreaTableEntry DbcZone;
        public WorldMapAreaEntry DbcWMZone;
        public MapEntry DbcMap;
        private Dictionary<uint, WowheadNodeData> entryData;

        public WowheadZoneData(int zoneid, AreaTableEntry dbczone, WorldMapAreaEntry dbcwmzone, MapEntry dbcmap)
        {
            zoneId = zoneid;
            DbcZone = dbczone;
            DbcWMZone = dbcwmzone;
            DbcMap = dbcmap;
            entryData = new Dictionary<uint, WowheadNodeData>();
        }

        public WowheadNodeData AddEntry(TrinityObjectTemplate template)
        {
            var nodeData = new WowheadNodeData(template);
            entryData.Add(template.entry, nodeData);
            return nodeData;
        }

        public void AddNodes(uint entryid, string nodeList)
        {
            var nodes = 
                new string(nodeList.Trim().
                        Where(ch => char.IsDigit(ch) || ch.Equals(',')).ToArray()).Split(",").
                        Where(node => !string.IsNullOrWhiteSpace(node)).
                        Select(row => Convert.ToUInt32(row));
            entryData[entryid].AddRange(nodes, DbcWMZone);
        }

        public bool Contains(uint entryid) => entryData.ContainsKey(entryid);

        public WowheadNodeData GetEntry(uint entryid) => entryData[entryid];

        public IEnumerable<uint> GetEntries() => entryData.Keys.AsEnumerable();
        public TrinityObjectTemplate GetTemplate(uint entryid) => entryData[entryid].TemplateObject;
        public IEnumerable<TrinityObjectTemplate> GetTemplates() => entryData.Values.Select(row => row.TemplateObject);
        public IEnumerable<WowheadPosition> GetNodes(uint entryid) => entryData[entryid].Positions;
    }

    public class WowheadNodeData
    {
        private uint entry;
        private TrinityObjectTemplate entryData;
        private List<WowheadPosition> positions;

        public WowheadNodeData(TrinityObjectTemplate entry)
        {
            this.entry = entry.entry;
            entryData = entry;
            positions = new List<WowheadPosition>();
        }

        public void AddPosition(uint nodePosition)
        {
            positions.Add(new WowheadPosition(nodePosition));
        }
        public void AddPosition(uint nodePosition, WorldMapAreaEntry WMentry)
        {
            positions.Add(new WowheadPosition(nodePosition, WMentry));
        }

        public void AddRange(IEnumerable<uint> positions, WorldMapAreaEntry wmdbc)
        {
            foreach (var position in positions)
                AddPosition(position, wmdbc);
        }

        public List<WowheadPosition> Positions => positions;
        public TrinityObjectTemplate TemplateObject => entryData;
    }

    public class WowheadPosition
    {
        private uint nodePacked;
        public float ZoneX;
        public float ZoneY;
        public float MapX;
        public float MapY;
        public bool inWorldDb;
        public TrinityObject NearestObject;

        public override string ToString() => $"{ZoneX}, {ZoneY} [{MapX}, {MapY}]";

        public WowheadPosition(uint packedNode)
        {
            Initialize(packedNode);
        }

        public WowheadPosition(uint packedNode, WorldMapAreaEntry WMentry)
        {
            Initialize(packedNode);
            CalcMapPosition(WMentry);
        }

        private void Initialize(uint packedNode)
        {
            nodePacked = packedNode;
            ZoneX = ((float)((uint)(packedNode / 1000)) / 10);
            ZoneY = ((float)((uint)(packedNode % 1000)) / 10);
            inWorldDb = false;
        }

        public void CalcMapPosition(WorldMapAreaEntry WMentry)
        {
            MapX = ZoneY * ((WMentry.BottomBoundary - WMentry.TopBoundary) / 100) + WMentry.TopBoundary;
            MapY = ZoneX * ((WMentry.RightBoundary - WMentry.LeftBoundary) / 100) + WMentry.LeftBoundary;
        }

        public float getDist(float x, float y)
        {
            float tempX = x - MapX;
            float tempY = y - MapY;
            return (float)Math.Sqrt(tempX * tempX + tempY * tempY);
        }
    }
}
