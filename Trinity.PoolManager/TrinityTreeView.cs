using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Trinity.PoolDB;
using Trinity.PoolManagerData;

namespace Trinity.PoolManager
{
    public class TrinityOverviewTreeNode : TreeNode
    {
        public TrinityObject TrinityObject;
        public TrinityObjectTemplate TrinityTemplate;
        public MapEntry TrinityMap;
        public AreaTableEntry TrinityZone;
        public AreaTableEntry TrinityArea;

        public TrinityOverviewTreeNode(string text) : base(text)
        {
            TrinityObject = null;
            TrinityTemplate = null;
            TrinityMap = null;
            TrinityZone = null;
            TrinityArea = null;
        }

        public bool IsTrinityObject => TrinityObject != null;
        public bool IsTrinityTemplate => TrinityTemplate != null;
        public bool IsTrinityMap => TrinityMap != null;
        public bool IsTrinityZone => TrinityZone != null;
    }

    public class TrinityLegacyPoolTreeNode : TreeNode
    {
        public LegacyPoolEntry LegacyPool;
        public MapEntry TrinityMap;
        public AreaTableEntry TrinityZone;
        public AreaTableEntry TrinityArea;
        public TrinityObject TrinityObject;
        public TrinityObjectTemplate TrinityTemplate;

        public TrinityLegacyPoolTreeNode(string text) : base(text)
        {
            LegacyPool = null;
            TrinityMap = null;
            TrinityZone = null;
            TrinityArea = null;
            TrinityObject = null;
            TrinityTemplate = null;
        }
    }

    public class TrinityWowheadTreeNode : TreeNode
    {
        public WowheadZoneData zoneData;
        public WowheadNodeData nodeData;
        public WowheadPosition posData;
        public MapEntry TrinityMap;
        public AreaTableEntry TrinityZone;
        public TrinityObjectTemplate TrinityTemplate;
        public TrinityObject TrinityObject;

        public TrinityWowheadTreeNode(string text) : base(text)
        {
            zoneData = null;
            nodeData = null;
            posData = null;
            TrinityMap = null;
            TrinityZone = null;
            TrinityTemplate = null;
            TrinityObject = null;
        }
    }

}
