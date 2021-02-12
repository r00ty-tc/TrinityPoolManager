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
}
