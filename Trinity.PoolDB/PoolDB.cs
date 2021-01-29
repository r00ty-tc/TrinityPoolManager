using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using MySql.Data.MySqlClient;
using Trinity.PoolManagerData;

namespace Trinity.PoolDB
{
    public class PoolDB
    {
        private readonly MySqlConnection sqlConnection;
        private SortedDictionary<uint, Creature> creatureData;
        private SortedDictionary<uint, GameObject> gameObjectData;
        private SortedDictionary<uint, LegacyPoolEntry> legacyPoolData;
        private SortedDictionary<uint, MapPoolItem> mapPoolData;
        private Dictionary<uint, LegacyPoolEntry> unstructLegacyPoolData;

        public PoolDB(string serverName, string userName, string passWord, string database)
        {
            creatureData = null;
            gameObjectData = null;
            legacyPoolData = null;
            unstructLegacyPoolData = null;
            mapPoolData = null;

            var builder = new MySqlConnectionStringBuilder
            {
                Server = serverName, UserID = userName, Password = passWord, Database = database
            };
            sqlConnection = new MySqlConnection(builder.ToString());
            sqlConnection.Open();
        }

        ~PoolDB()
        {
            if (sqlConnection.State != ConnectionState.Broken && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            sqlConnection.Dispose();
        }

        public void LoadData()
        {
            // Load all data into internal structures
            loadPools();
            loadCreatures();
            loadGameObjects();
            loadLegacyPools();
        }

        protected void loadCreatures()
        {
            // ============================
            // Load creature_template table
            // ============================
            var templates = new Dictionary<uint, CreatureTemplate>();
            var templateQuery =
                @"SELECT entry, difficulty_entry_1, difficulty_entry_2, difficulty_entry_3, KillCredit1, KillCredit2, "
                + @"modelid1, modelid2, modelid3, modelid4, name, subname, IconName, gossip_menu_id, minlevel, "
                + @"maxlevel, exp, faction, npcflag, speed_walk, speed_run, scale, rank, dmgschool, BaseAttackTime, "
                + @"RangeAttackTime, BaseVariance, RangeVariance, unit_class, unit_flags, unit_flags2, dynamicflags, family, "
                + @"type, type_flags, lootid, pickpocketloot, skinloot, PetSpellDataId, VehicleId, mingold, maxgold, AIName, "
                + @"MovementType, HoverHeight, HealthModifier, ManaModifier, ArmorModifier, DamageModifier, ExperienceModifier, "
                + @"RacialLeader, movementId, RegenHealth, mechanic_immune_mask, spell_school_immune_mask, flags_extra, ScriptName "
                + "from creature_template";

            creatureData = new SortedDictionary<uint, Creature>();

            using (var templateCmd = new MySqlCommand(templateQuery, sqlConnection))
            {
                using (var creatureTemplateRecords = templateCmd.ExecuteReader())
                {
                    while (creatureTemplateRecords.Read())
                    {
                        var template = new CreatureTemplate
                        {
                            entry = creatureTemplateRecords.GetUInt32(0),
                            difficultyEntry =
                                new uint[]
                                {
                                    creatureTemplateRecords.GetUInt32(1), creatureTemplateRecords.GetUInt32(2),
                                    creatureTemplateRecords.GetUInt32(3)
                                },
                            killCredit =
                                new uint[] {creatureTemplateRecords.GetUInt32(4), creatureTemplateRecords.GetUInt32(5)},
                            modelid = new uint[]
                            {
                                creatureTemplateRecords.GetUInt32(6), creatureTemplateRecords.GetUInt32(7),
                                creatureTemplateRecords.GetUInt32(8), creatureTemplateRecords.GetUInt32(9)
                            },
                            name = !creatureTemplateRecords.IsDBNull(10)
                                ? creatureTemplateRecords.GetString(10)
                                : null,
                            subName = !creatureTemplateRecords.IsDBNull(11)
                                ? creatureTemplateRecords.GetString(11)
                                : null,
                            iconName = !creatureTemplateRecords.IsDBNull(12)
                                ? creatureTemplateRecords.GetString(12)
                                : null,
                            gossipMenuId = creatureTemplateRecords.GetUInt32(13),
                            minLevel = creatureTemplateRecords.GetUInt32(14),
                            maxLevel = creatureTemplateRecords.GetUInt32(15),
                            exp = creatureTemplateRecords.GetInt32(16),
                            faction = creatureTemplateRecords.GetUInt32(17),
                            npcFlag = creatureTemplateRecords.GetUInt32(18),
                            speedWalk = creatureTemplateRecords.GetFloat(19),
                            speedRun = creatureTemplateRecords.GetFloat(20),
                            scale = creatureTemplateRecords.GetFloat(21),
                            rank = creatureTemplateRecords.GetUInt32(22),
                            dmgSchool = creatureTemplateRecords.GetInt32(23),
                            baseAttackTime = creatureTemplateRecords.GetUInt32(24),
                            rangeAttackTime = creatureTemplateRecords.GetUInt32(25),
                            baseVariance = creatureTemplateRecords.GetFloat(26),
                            rangeVariance = creatureTemplateRecords.GetFloat(27),
                            unit_class = creatureTemplateRecords.GetUInt32(28),
                            unitFlags = new uint[]
                            {
                                creatureTemplateRecords.GetUInt32(29), creatureTemplateRecords.GetUInt32(30)
                            },
                            dynamicFlags = creatureTemplateRecords.GetUInt32(31),
                            family = creatureTemplateRecords.GetInt32(32)
                        };
                        templates.Add(template.entry, template);
                    }
                }
            }

            // ===================
            // Load creature table
            // ===================
            var creatureQuery =
                @"SELECT guid, id, map, zoneId, areaId, spawnMask, phaseMask, modelid, equipment_id, position_x, "
                + "position_y, position_z, orientation, spawntimesecs, wander_distance, currentwaypoint, curhealth, "
                + "curmana, MovementType, npcflag, unit_flags, dynamicflags, ScriptName, VerifiedBuild "
                + "FROM creature";
            using (var creatureCmd = new MySqlCommand(creatureQuery, sqlConnection))
            {
                using (var creatureRecords = creatureCmd.ExecuteReader())
                {
                    while (creatureRecords.Read())
                    {
                        var creatureId = creatureRecords.GetUInt32(1);
                        // Find template
                        var result = templates.TryGetValue(creatureId, out CreatureTemplate creatureTemplate);
                        if (!result)
                            creatureTemplate = null;

                        var creature = new Creature
                        {
                            type = ObjectType.OBJECT_CREATURE,
                            guid = creatureRecords.GetUInt32(0),
                            id = creatureRecords.GetUInt32(1),
                            creatureTemplate = creatureTemplate,
                            map = creatureRecords.GetUInt32(2),
                            zoneId = creatureRecords.GetUInt32(3),
                            areaId = creatureRecords.GetUInt32(4),
                            spawnMask = creatureRecords.GetUInt32(5),
                            phaseMask = creatureRecords.GetUInt32(6),
                            modelId = creatureRecords.GetUInt32(7),
                            equipmentId = creatureRecords.GetInt32(8),
                            positionX = creatureRecords.GetFloat(9),
                            positionY = creatureRecords.GetFloat(10),
                            positionZ = creatureRecords.GetFloat(11),
                            orientation = creatureRecords.GetFloat(12),
                            spawntimeSecs = creatureRecords.GetInt32(13),
                            spawnDist = creatureRecords.GetFloat(14),
                            currentWaypoint = creatureRecords.GetUInt32(15),
                            curHealth = creatureRecords.GetUInt32(16),
                            curMana = creatureRecords.GetUInt32(17),
                            movementType = creatureRecords.GetUInt32(18),
                            npcFlag = creatureRecords.GetUInt32(19),
                            unitFlags = creatureRecords.GetUInt32(20),
                            dynamicFlags = creatureRecords.GetUInt32(21),
                            scriptName = !creatureRecords.IsDBNull(22) ? creatureRecords.GetString(22) : null
                        };
                        creatureData.Add(creature.guid, creature);
                    }
                }
            }
        }

        protected void loadGameObjects()
        {
            // ==============================
            // Load gameobject_template table
            // ==============================
            var templates = new Dictionary<uint, GameObjectTemplate>();
            var templateQuery =
                @"SELECT entry, type, displayId, name, IconName, castBarCaption, unk1, size, Data0, Data1, "
                + @"Data2, Data3, Data4, Data5, Data6, Data7, Data8, Data9, Data10, Data11, Data12, "
                + @"Data13, Data14, Data15, Data16, Data17, Data18, Data19, Data20, Data21, Data22, "
                + @"Data23, AIName, ScriptName, VerifiedBuild "
                + "from gameobject_template";

            gameObjectData = new SortedDictionary<uint, GameObject>();

            using (var templateCmd = new MySqlCommand(templateQuery, sqlConnection))
            {
                using (var gameObjectTemplateRecords = templateCmd.ExecuteReader())
                {
                    while (gameObjectTemplateRecords.Read())
                    {
                        var template = new GameObjectTemplate
                        {
                            entry = gameObjectTemplateRecords.GetUInt32(0),
                            type = gameObjectTemplateRecords.GetUInt32(1),
                            displayId = gameObjectTemplateRecords.GetUInt32(2),
                            name = !gameObjectTemplateRecords.IsDBNull(3)
                                ? gameObjectTemplateRecords.GetString(3)
                                : null,
                            iconName = !gameObjectTemplateRecords.IsDBNull(4)
                                ? gameObjectTemplateRecords.GetString(4)
                                : null,
                            castBarCaption = !gameObjectTemplateRecords.IsDBNull(5)
                                ? gameObjectTemplateRecords.GetString(5)
                                : null,
                            unk1 = !gameObjectTemplateRecords.IsDBNull(6)
                                ? gameObjectTemplateRecords.GetString(6)
                                : null,
                            size = gameObjectTemplateRecords.GetFloat(7),
                            data = new long[]
                            {
                                gameObjectTemplateRecords.GetInt64(8), // Data0
                                gameObjectTemplateRecords.GetInt64(9), gameObjectTemplateRecords.GetInt64(10),
                                gameObjectTemplateRecords.GetInt64(11), gameObjectTemplateRecords.GetInt64(12),
                                gameObjectTemplateRecords.GetInt64(13), gameObjectTemplateRecords.GetInt64(14),
                                gameObjectTemplateRecords.GetInt64(15), gameObjectTemplateRecords.GetInt64(16),
                                gameObjectTemplateRecords.GetInt64(17),
                                gameObjectTemplateRecords.GetInt64(18), // Data10
                                gameObjectTemplateRecords.GetInt64(19), gameObjectTemplateRecords.GetInt64(20),
                                gameObjectTemplateRecords.GetInt64(21), gameObjectTemplateRecords.GetInt64(22),
                                gameObjectTemplateRecords.GetInt64(23), gameObjectTemplateRecords.GetInt64(24),
                                gameObjectTemplateRecords.GetInt64(25), gameObjectTemplateRecords.GetInt64(26),
                                gameObjectTemplateRecords.GetInt64(27),
                                gameObjectTemplateRecords.GetInt64(28), // Data 20
                                gameObjectTemplateRecords.GetInt64(29), gameObjectTemplateRecords.GetInt64(30),
                                gameObjectTemplateRecords.GetInt64(31) // Data 23
                            },
                            aIName = gameObjectTemplateRecords.GetString(32),
                            scriptName = gameObjectTemplateRecords.GetString(33)
                        };
                        templates.Add(template.entry, template);
                    }
                }
            }

            // =====================
            // Load gameobject table
            // =====================
            var gameObjectQuery =
                @"SELECT guid, id, map, zoneId, areaId, spawnMask, phaseMask, position_x, position_y, position_z, "
                + @"orientation, rotation0, rotation1, rotation2, rotation3, spawntimesecs, animprogress, state, "
                + @"ScriptName, VerifiedBuild "
                + "FROM gameobject";
            using (var gameObjectCmd = new MySqlCommand(gameObjectQuery, sqlConnection))
            {
                using (var gameObjectRecords = gameObjectCmd.ExecuteReader())
                {
                    while (gameObjectRecords.Read())
                    {
                        // Find template
                        var gameObjectId = gameObjectRecords.GetUInt32(1);
                        var result = templates.TryGetValue(gameObjectId, out GameObjectTemplate gameObjectTemplate);
                        if (!result)
                            gameObjectTemplate = null;

                        var gameObject = new GameObject
                        {
                            type = ObjectType.OBJECT_GAMEOBJECT,
                            guid = gameObjectRecords.GetUInt32(0),
                            id = gameObjectRecords.GetUInt32(1),
                            goTemplate = gameObjectTemplate,
                            map = gameObjectRecords.GetUInt32(2),
                            zoneId = gameObjectRecords.GetUInt32(3),
                            areaId = gameObjectRecords.GetUInt32(4),
                            spawnMask = gameObjectRecords.GetUInt32(5),
                            phaseMask = gameObjectRecords.GetUInt32(6),
                            positionX = gameObjectRecords.GetFloat(7),
                            positionY = gameObjectRecords.GetFloat(8),
                            positionZ = gameObjectRecords.GetFloat(9),
                            orientation = gameObjectRecords.GetFloat(10),
                            rotation0 = gameObjectRecords.GetFloat(11),
                            rotation1 = gameObjectRecords.GetFloat(12),
                            rotation2 = gameObjectRecords.GetFloat(13),
                            rotation3 = gameObjectRecords.GetFloat(14),
                            spawntimeSecs = gameObjectRecords.GetInt32(15),
                            animProgress = gameObjectRecords.GetUInt32(16),
                            state = gameObjectRecords.GetUInt32(17),
                            scriptName = !gameObjectRecords.IsDBNull(18) ? gameObjectRecords.GetString(18) : null
                        };
                        gameObjectData.Add(gameObject.guid, gameObject);
                    }
                }
            }
        }

        protected void loadLegacyPools()
        {
            // ============================
            // Load Old pool_template table
            // ============================
            var legacyPoolTemplateQuery = @"SELECT entry, max_limit, description FROM pool_template";

            legacyPoolData = new SortedDictionary<uint, LegacyPoolEntry>();
            unstructLegacyPoolData = new Dictionary<uint, LegacyPoolEntry>();

            using (var legacyPoolTemplateCmd = new MySqlCommand(legacyPoolTemplateQuery, sqlConnection))
            {
                using (var legacyPoolTemplateRecords = legacyPoolTemplateCmd.ExecuteReader())
                {
                    while (legacyPoolTemplateRecords.Read())
                    {
                        var legacyPoolTemplate = new LegacyPoolEntry
                        {
                            poolId = legacyPoolTemplateRecords.GetUInt32(0),
                            maxLimit = legacyPoolTemplateRecords.GetUInt32(1),
                            description = legacyPoolTemplateRecords.GetString(2)
                        };

                        legacyPoolData.Add(legacyPoolTemplate.poolId, legacyPoolTemplate);
                        unstructLegacyPoolData.Add(legacyPoolTemplate.poolId, legacyPoolTemplate);
                    }
                }
            }

            // ===========================
            // Load old pool_members table
            // ===========================
            var legacyPoolMembersQuery = @"SELECT type, spawnId, poolSpawnId, chance, description FROM pool_members";
            using (var legacyPoolMembersCmd = new MySqlCommand(legacyPoolMembersQuery, sqlConnection))
            {
                using (var legacyPoolMembersRecords = legacyPoolMembersCmd.ExecuteReader())
                {
                    while (legacyPoolMembersRecords.Read())
                    {
                        var type = (LegacyPoolType) legacyPoolMembersRecords.GetUInt32(0);
                        var poolId = legacyPoolMembersRecords.GetUInt32(2);
                        // Find existing template
                        if (legacyPoolData.TryGetValue(poolId, out LegacyPoolEntry poolEntry))
                        {
                            var poolObject = new LegacyPoolObject
                            {
                                type = type,
                                spawnId = legacyPoolMembersRecords.GetUInt32(1),
                                poolSpawnId = poolId,
                                chance = legacyPoolMembersRecords.GetFloat(3),
                                description = legacyPoolMembersRecords.GetString(4)
                            };

                            switch (type)
                            {
                                // Pool in a pool
                                case LegacyPoolType.POOLTYPE_POOL:
                                    // Fetch child pool
                                    if (legacyPoolData.TryGetValue(poolObject.spawnId, out LegacyPoolEntry childPool))
                                    {
                                        if (childPool.parentPool != null)
                                            throw new Exception(
                                                $"Pool {poolObject.spawnId} attempted to add two parent pools ({childPool.parentPool.poolId} and {poolObject.poolSpawnId}");

                                        if (poolEntry.childPools.Contains(childPool))
                                            throw new Exception(
                                                $"Pool {poolEntry.poolId} already contains child pool {childPool.poolId}");

                                        childPool.parentPool = poolEntry;
                                        poolEntry.childPools.Add(childPool);
                                        childPool.poolItems.Add(poolObject);
                                    }
                                    else
                                    {
                                        Debug.Print(
                                            $"Pool with no parent {poolObject.spawnId} (parent: {poolObject.poolSpawnId}");
                                    }

                                    break;
                                case LegacyPoolType.POOLTYPE_CREATURE:
                                    if (creatureData.TryGetValue(poolObject.spawnId, out Creature creature))
                                    {
                                        poolObject.trinityObject = creature;
                                        poolEntry.poolItems.Add(poolObject);
                                        creature.legacyPools.Add(poolEntry);
                                    }

                                    break;
                                case LegacyPoolType.POOLTYPE_GAMEOBJECT:
                                    if (gameObjectData.TryGetValue(poolObject.spawnId, out GameObject gameObject))
                                    {
                                        poolObject.trinityObject = gameObject;
                                        poolEntry.poolItems.Add(poolObject);
                                        gameObject.legacyPools.Add(poolEntry);
                                    }

                                    break;
                                default:
                                    break;
                            }
                        }

                    }
                }
            }

            var poolsToDelete = new List<LegacyPoolEntry>();
            // Remove all non root pools from dictionary
            foreach (var pool in legacyPoolData.Values)
            {
                if (pool.parentPool != null)
                {
                    poolsToDelete.Add(pool);
                }
                else
                {
                    // Otherwise mark all child pools 
                    foreach (var childPool in pool.childPools)
                        markSubPools(childPool, pool);
                }

            }

            foreach (var pool in poolsToDelete)
                legacyPoolData.Remove(pool.poolId);
        }

        private void markSubPools(LegacyPoolEntry pool, LegacyPoolEntry rootPool)
        {
            // Recursively iterate structure to mark root pool
            pool.rootPool = rootPool;
            foreach (var childPool in pool.childPools)
            {
                markSubPools(childPool, rootPool);
            }
        }

        public void loadPools()
        {
            // =====================
            // Load Pool spawnpoints
            // =====================
            var spawnPointQuery = @"SELECT map, pointId, zoneId, areaId, gridId, positionX, positionY, "
                                  + @"positionZ, orientation, rotation0, rotation1, rotation2, rotation3 "
                                  + @"from mappool_spawnpoints";

            mapPoolData = new SortedDictionary<uint, MapPoolItem>();

            using (var spawnPointCmd = new MySqlCommand(spawnPointQuery, sqlConnection))
            {
                using (var spawnPointRecords = spawnPointCmd.ExecuteReader())
                {
                    while (spawnPointRecords.Read())
                    {
                        var spawnPoint = new SpawnPoint
                        {
                            map = spawnPointRecords.GetUInt32(0),
                            pointId = spawnPointRecords.GetUInt32(1),
                            zoneId = spawnPointRecords.GetUInt32(2),
                            areaId = spawnPointRecords.GetUInt32(3),
                            gridId = spawnPointRecords.GetUInt32(4),
                            positionX = spawnPointRecords.GetFloat(5),
                            positionY = spawnPointRecords.GetFloat(6),
                            positionZ = spawnPointRecords.GetFloat(7),
                            orientation = spawnPointRecords.GetFloat(8),
                            rotation0 = spawnPointRecords.GetFloat(9),
                            rotation1 = spawnPointRecords.GetFloat(10),
                            rotation2 = spawnPointRecords.GetFloat(11),
                            rotation3 = spawnPointRecords.GetFloat(12)
                        };

                        var thisMap = MapPoolItem.FindOrGetNew(mapPoolData, spawnPoint.map);
                        if (thisMap.spawnPoints.ContainsKey(spawnPoint.pointId))
                            throw new Exception($"Map: {spawnPoint.map} has duplicate spawnpoint {spawnPoint.pointId}");

                        thisMap.spawnPoints.Add(spawnPoint.pointId, spawnPoint);
                    }
                }
            }

            // ========================
            // Load pool_template table
            // ========================
            var poolTemplateQuery =
                @"SELECT map, poolId, poolType, phaseMask, spawnMask, minLimit, maxLimit, MovementType, "
                + @"spawnDist, spawntimeSecsMin, spawntimeSecsMax, spawntimeSecsFast, corpsetimeSecsLoot, "
                + @"corpsetimeSecsNoLoot, poolFlags, description "
                + @"FROM mappool_template";

            using (var poolTemplateCmd = new MySqlCommand(poolTemplateQuery, sqlConnection))
            {
                using (var poolTemplateRecords = poolTemplateCmd.ExecuteReader())
                {
                    while (poolTemplateRecords.Read())
                    {
                        var poolEntry = new PoolEntry
                        {
                            map = poolTemplateRecords.GetUInt32(0),
                            poolId = poolTemplateRecords.GetUInt32(1),
                            poolType = (PoolType) poolTemplateRecords.GetUInt16(2),
                            phaseMask = poolTemplateRecords.GetUInt32(3),
                            spawnMask = poolTemplateRecords.GetUInt32(4),
                            minLimit = poolTemplateRecords.GetUInt32(5),
                            maxLimit = poolTemplateRecords.GetUInt32(6),
                            movementType = poolTemplateRecords.GetUInt32(7),
                            spawnDist = poolTemplateRecords.GetFloat(8),
                            spawntimeSecsMin = poolTemplateRecords.GetUInt32(9),
                            spawntimeSecsMax = poolTemplateRecords.GetUInt32(10),
                            spawntimeSecsFast = poolTemplateRecords.GetUInt32(11),
                            corpsetimeSecsLoot = poolTemplateRecords.GetUInt32(12),
                            corpsetimeSecsNoLoot = poolTemplateRecords.GetUInt32(13),
                            flags = poolTemplateRecords.GetUInt32(14),
                            description = poolTemplateRecords.GetString(15)
                        };

                        var thisMap = MapPoolItem.FindOrGetNew(mapPoolData, poolEntry.map);
                        if (thisMap.pools.ContainsKey(poolEntry.poolId))
                            throw new Exception($"Map: {poolEntry.map} contains duplicate pool {poolEntry.poolId}");

                        thisMap.pools.Add(poolEntry.poolId, poolEntry);
                        thisMap.unstructPools.Add(poolEntry.poolId, poolEntry);
                    }
                }
            }

            // Load pool_hierarchy table
            var poolHierarchyQuery = @"SELECT map, poolId, childPoolId FROM mappool_hierarchy";
            var poolsToDelete = new List<PoolEntry>();

            using (var poolHierarchyCmd = new MySqlCommand(poolHierarchyQuery, sqlConnection))
            {
                using (var poolHierarchyRecords = poolHierarchyCmd.ExecuteReader())
                {
                    while (poolHierarchyRecords.Read())
                    {
                        var mapId = poolHierarchyRecords.GetUInt32(0);
                        var poolId = poolHierarchyRecords.GetUInt32(1);
                        var childPoolId = poolHierarchyRecords.GetUInt32(2);
                        if (mapPoolData.TryGetValue(mapId, out MapPoolItem mapItem))
                        {
                            var poolTest = mapItem.pools.TryGetValue(poolId, out PoolEntry pool);
                            if (!poolTest)
                                throw new Exception($"Map: {mapId} missing Pool {poolId}");

                            var childTest = mapItem.pools.TryGetValue(childPoolId, out PoolEntry childPool);
                            if (!childTest)
                                throw new Exception(
                                    $"Map: {mapId} missing child pool {childPoolId} for parent pool {poolId}");

                            if (pool.childPools.Contains(childPool))
                                throw new Exception(
                                    $"Map: {mapId} attempted to add {childPoolId} to parent pool {poolId} but was already present");

                            pool.childPools.Add(childPool);
                            childPool.parentPool = pool;
                            poolsToDelete.Add(childPool);
                        }
                        else
                        {
                            throw new Exception($"Map {mapId} missing");
                        }
                    }
                }
            }

            // Remove non root pools (they still exist in the hierarchy and unsorted master list)
            foreach (var pool in poolsToDelete)
                mapPoolData[pool.map].pools.Remove(pool.poolId);

            // Setup root pools
            foreach (var map in mapPoolData.Values)
                foreach (var pool in map.pools.Values)
                    foreach (var childPool in pool.childPools)
                        markSubPools(childPool, pool);
        }

        private void markSubPools(PoolEntry pool, PoolEntry rootPool)
        {
            // Recursively iterate structure to mark root pool
            pool.rootPool = rootPool;
            foreach (var childPool in pool.childPools)
            {
                markSubPools(childPool, rootPool);
            }
        }
    }
}
