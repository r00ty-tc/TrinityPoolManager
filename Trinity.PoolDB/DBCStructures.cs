using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using DBFileReaderLib;
using DBFileReaderLib.Attributes;

namespace Trinity.PoolDB
{
    public sealed class MapEntry
    {
        [Index(true)]
        public int Id;
        public string Directory;
        public int InstanceType;
        public int Flags;
        public int PVP;
        [Locale(0)]
        public string MapName_Lang;
        public int AreaTableID;
        [Locale(0)]
        public string MapDescription0_Lang;
        [Locale(0)]
        public string MapDescription1_Lang;
        public int LoadingScreenID;
        public float MinimapIconScale;
        public int CorpseMapID;
        public float CorpseX;
        public float CorpseY;
        public int TimeOfDayOverride;
        public int ExpansionID;
        public int RaidOffset;
        public int MaxPlayers;

        public override string ToString() => $"{Id}: {MapName_Lang}";
    }

    public sealed class AreaTableEntry
    {
        [Index(true)]
        public int ID;
        public int ContinentID;
        public int ParentAreaID;
        public int AreaBit;
        public int Flags;
        public int SoundProviderPref;
        public int SoundProviderPrefUnderwater;
        public int AmbienceID;
        public int ZoneMusic;
        public int IntroSound;
        public int ExplorationLevel;
        [Locale(0)]
        public string AreaName_Lang;
        public int FactionGroupMask;
        [Cardinality(4)] 
        public int LiquidTypeID;
        public int MinElevation;
        public int Ambient_Multiplier;
        public int Lightid;

        public override string ToString() => $"{ID}: {AreaName_Lang}";
    }
}
