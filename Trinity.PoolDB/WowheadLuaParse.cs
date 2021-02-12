using System;
using System.Collections.Generic;
using System.Linq;

namespace Trinity.PoolDB
{
    public class WowheadDBStore
    {
        public Dictionary<int, WowheadZoneData> zoneData;

        public WowheadDBStore()
        {
            zoneData = new Dictionary<int, WowheadZoneData>();
        }

        public WowheadZoneData AddZone(int zoneId)
        {
            var zone = new WowheadZoneData(zoneId);
            zoneData.Add(zoneId, zone);
            return zone;
        }

        public bool TryAddZone(int zoneId, out WowheadZoneData zonedata)
        {
            if (!Contains(zoneId))
            {
                zonedata = null;
                return false;
            }

            zonedata = AddZone(zoneId);
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
        public Dictionary<uint, List<uint>> entryData;

        public WowheadZoneData(int zoneid)
        {
            zoneId = zoneid;
            entryData = new Dictionary<uint, List<uint>>();
        }

        public List<uint> AddEntry(uint entryid)
        {
            var nodeData = new List<uint>();
            entryData.Add(entryid, nodeData);
            return nodeData;
        }

        public void AddNodes(uint entryid, string nodeList)
        {
            var nodes = 
                new string(nodeList.Trim().
                        Where(ch => char.IsDigit(ch) || ch.Equals(',')).ToArray()).Split(',').
                        Select(row => Convert.ToUInt32(row));
            entryData[entryid].AddRange(nodes);
        }

        public bool Contains(uint entryid) => entryData.ContainsKey(entryid);

        public List<uint> GetEntry(uint entryid) => entryData[entryid];

        public IEnumerable<uint> GetEntries() => entryData.Keys.AsEnumerable();
        public IEnumerable<uint> GetNodes(uint entryid) => entryData[entryid].AsEnumerable();
    }
}
