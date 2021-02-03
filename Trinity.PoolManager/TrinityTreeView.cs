using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Trinity.PoolDB;
using Trinity.PoolManagerData;

namespace Trinity.PoolManager
{
    public class TrinityTreeNode : TreeNode
    {
        public TrinityObject TrinityObject;
        public TrinityObjectTemplate TrinityTemplate;
        public MapEntry TrinityMap;
        public AreaTableEntry TrinityZone;
        public AreaTableEntry TrinityArea;

        public TrinityTreeNode(string text) : base(text)
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
}
