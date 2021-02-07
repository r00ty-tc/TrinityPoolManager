using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Trinity.PoolDB;

namespace Trinity.PoolManagerData
{
    public class TrinityObject
    {
        public ObjectType type;
        public uint guid;
        public uint id;
        public uint map;
        public uint zoneId;
        public uint areaId;
        public uint spawnMask;
        public uint phaseMask;
        public float positionX;
        public float positionY;
        public float positionZ;
        public float orientation;
        public int spawntimeSecs;
        public string scriptName;
        public List<LegacyPoolEntry> legacyPools;
        public AreaTableEntry dbcZone;
        public AreaTableEntry dbcArea;
        public MapEntry dbcMap;
        public TrinityObjectTemplate trinityTemplateObject;

        public override string ToString() => $"{guid} ({dbcArea})";
        public TrinityObject()
        {
            legacyPools = new List<LegacyPoolEntry>();
            trinityTemplateObject = null;
        }

        public Creature AsCreature()
        {
            if (type != ObjectType.OBJECT_CREATURE)
                return null;

            return (Creature) this;
        }
        public GameObject AsGameObject()
        {
            if (type != ObjectType.OBJECT_GAMEOBJECT)
                return null;

            return (GameObject)this;
        }
    }

    public class TrinityObjectTemplate
    {
        public ObjectType objectType;
        public uint entry;
        public string name;
        public string iconName;
        public List<PoolEntry> memberPools;
        public List<TrinityObject> objects;

        public TrinityObjectTemplate()
        {
            memberPools = new List<PoolEntry>();
            objects = new List<TrinityObject>();
        }

        public override string ToString() => $"{entry}: {name}";
    }

    public class Creature : TrinityObject
    {
        public uint modelId;
        public int equipmentId;
        public float spawnDist;
        public uint currentWaypoint;
        public uint curHealth;
        public uint curMana;
        public uint movementType;
        public uint npcFlag;
        public uint unitFlags;
        public uint dynamicFlags;
    }

    public class CreatureTemplate : TrinityObjectTemplate
    {
        public uint[] difficultyEntry;
        public uint[] killCredit;
        public uint[] modelid;
        public string subName;
        public uint gossipMenuId;
        public uint minLevel;
        public uint maxLevel;
        public int exp;
        public uint faction;
        public uint npcFlag;
        public float speedWalk;
        public float speedRun;
        public float scale;
        public uint rank;
        public int dmgSchool;
        public uint baseAttackTime;
        public uint rangeAttackTime;
        public float baseVariance;
        public float rangeVariance;
        public uint unit_class;
        public uint[] unitFlags;
        public uint dynamicFlags;
        public int family;
        public uint trainerType;
        public uint trainerSpell;

        public override string ToString() => $"{entry}: [{minLevel}-{maxLevel}] ({name})";

        public CreatureTemplate() : base()
        {
            difficultyEntry = new uint[3];
            killCredit = new uint[2];
            modelid = new uint[4];
            unitFlags = new uint[2];
            objectType = ObjectType.OBJECT_CREATURE;
        }
    }

    public class GameObject : TrinityObject
    {
        public float rotation0;
        public float rotation1;
        public float rotation2;
        public float rotation3;
        public uint animProgress;
        public uint state;
    }

    public class GameObjectTemplate : TrinityObjectTemplate
    {
        public uint type;
        public uint displayId;
        public string castBarCaption;
        public string unk1;
        public float size;
        public long[] data;
        public string aIName;
        public string scriptName;

        public GameObjectTemplate() : base()
        {
            data = new long[24];
            memberPools = new List<PoolEntry>();
            objectType = ObjectType.OBJECT_GAMEOBJECT;
        }
    }

    public class MapPoolItem
    {
        public uint mapId;
        public SortedDictionary<uint, PoolEntry> pools;
        public Dictionary<uint, PoolEntry> unstructPools;
        public SortedDictionary<uint, SpawnPoint> spawnPoints;

        public MapPoolItem()
        {
            pools = new SortedDictionary<uint, PoolEntry>();
            unstructPools = new Dictionary<uint, PoolEntry>();
            spawnPoints = new SortedDictionary<uint, SpawnPoint>();
        }

        public static MapPoolItem FindOrGetNew(SortedDictionary<uint, MapPoolItem> items, uint mapId)
        {
            if (items.TryGetValue(mapId, out MapPoolItem item))
                return item;

            var newItem = new MapPoolItem();
            newItem.mapId = mapId;
            items.Add(mapId, newItem);
            return newItem;
        }
    }

    public enum ObjectType
    {
        OBJECT_CREATURE,
        OBJECT_GAMEOBJECT
    }

    public enum PoolType
    {
        POOLTYPE_CREATURE,
        POOLTYPE_GAMEOBJECT,
        POOLTYPE_POOL
    }

    public class PoolEntry
    {
        public uint map;
        public uint poolId;
        public PoolType poolType;
        public uint phaseMask;
        public uint spawnMask;
        public uint minLimit;
        public uint maxLimit;
        public uint movementType;
        public float spawnDist;
        public uint spawntimeSecsMin;
        public uint spawntimeSecsMax;
        public uint spawntimeSecsFast;
        public uint corpsetimeSecsLoot;
        public uint corpsetimeSecsNoLoot;
        public string description;
        public float chance;
        public uint flags;
        public PoolEntry parentPool;
        public PoolEntry rootPool;
        public List<PoolEntry> childPools;
        public List<PoolCreature> creatures;
        public List<PoolGameObject> gameObjects;
        public List<SpawnPoint> spawnPoints;

        public bool IsRootPool()
        {
            return (parentPool == null);
        }

        public PoolEntry()
        {
            childPools = new List<PoolEntry>();
            creatures = new List<PoolCreature>();
            gameObjects = new List<PoolGameObject>();
            spawnPoints = new List<SpawnPoint>();
        }
    }

    public class PoolObject
    {
        public ObjectType type;
        public uint map;
        public uint poolId;
        public uint entry;
        public float chance;
        public TrinityObjectTemplate trinityObject;

        public PoolCreature AsCreature()
        {
            if (type != ObjectType.OBJECT_CREATURE)
                return null;

            return (PoolCreature)this;
        }

        public PoolGameObject AsGameObject()
        {
            if (type != ObjectType.OBJECT_GAMEOBJECT)
                return null;

            return (PoolGameObject)this;
        }
    }
    public class PoolCreature : PoolObject
    {
        public uint modelId;
        public int equipmentId;
        public uint currentWaypoint;
        public uint curHealth;
        public uint curMana;
        public uint npcFlag;
        public uint unitFlags;
        public uint dynamicFlags;

        public PoolCreature()
        {
            type = ObjectType.OBJECT_CREATURE;
        }
    }

    public class PoolGameObject : PoolObject
    {

        public uint animProgress;
        public uint state;

        public PoolGameObject()
        {
            type = ObjectType.OBJECT_GAMEOBJECT;
        }
    }

    public class SpawnPoint
    {
        public uint map;
        public uint pointId;
        public uint zoneId;
        public uint areaId;
        public uint gridId;
        public float positionX;
        public float positionY;
        public float positionZ;
        public float orientation;
        public float rotation0;
        public float rotation1;
        public float rotation2;
        public float rotation3;
        public AreaTableEntry dbcZone;
        public AreaTableEntry dbcArea;
        public MapEntry dbcMap;
    }

    public enum LegacyPoolType
    {
        POOLTYPE_CREATURE,
        POOLTYPE_GAMEOBJECT,
        POOLTYPE_POOL
    }

    public class LegacyPoolObject
    {
        public LegacyPoolType type;
        public uint spawnId;
        public uint poolSpawnId;
        public float chance;
        public string description;
        public TrinityObject trinityObject;

        public LegacyPoolObject()
        {
            trinityObject = null;
        }
    }

    public class LegacyPoolEntry
    {
        public uint poolId;
        public uint maxLimit;
        public string description;
        public LegacyPoolEntry parentPool;
        public LegacyPoolEntry rootPool;
        public List<LegacyPoolEntry> childPools;
        public List<LegacyPoolObject> poolItems;
        public List<MapEntry> poolMaps;
        public List<AreaTableEntry> poolZones;

        public LegacyPoolEntry()
        {
            childPools = new List<LegacyPoolEntry>();
            poolItems = new List<LegacyPoolObject>();
            poolMaps = new List<MapEntry>();
            poolZones = new List<AreaTableEntry>();
        }

        public override string ToString() => $"{poolId}: {description} [Max: {maxLimit}]";
    }
}
