using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;

namespace Trinity.PoolDB
{
    public class ConfigData
    {
        public string SqlServerHost { get; set; }
        public string SqlServerUser { get; set; }
        public string SqlServerPass { get; set; }
        public string SqlServerDB { get; set; }
        public string DbcFolder { get; set; }

        public ConfigData()
        {
            SqlServerHost = string.Empty;
            SqlServerUser = string.Empty;
            SqlServerPass = string.Empty;
            SqlServerDB = string.Empty;
            DbcFolder = string.Empty;
        }
    }

    public class PoolManagerConfig
    {
        private ConfigData configData;

        private bool configLoaded;
        //public ConfigData Data => configData;

        public ConfigData Data => configData;

        public PoolManagerConfig()
        {
            configData = new ConfigData();
            configLoaded = false;

            // Just try to load, don't care if we fail here
            try
            {
                LoadConfig();
            }
            catch
            {
            }
        }

        public bool LoadConfig()
        {
            try
            {
                var folderName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                                 @"\TrinityCore";
                var data = File.ReadAllText(folderName + @"\PoolManager.conf");
                configData = JsonSerializer.Deserialize<ConfigData>(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string SaveConfig(bool skipExceptions = false)
        {
            var configValid = ValidateConfig(skipExceptions);
            if (configValid != null)
                return configValid;
                
            var folderName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                             @"\TrinityCore";
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.IgnoreNullValues = false;
            var data = JsonSerializer.Serialize<ConfigData>(configData, options);
            File.WriteAllText(folderName + @"\PoolManager.conf", data, Encoding.UTF8);
            return null;
        }

        public string ValidateConfig(bool skipException = false)
        {
            try
            {
                var db = PoolDB.GetDatabases(configData.SqlServerHost, configData.SqlServerUser,
                    configData.SqlServerPass);

                if (!db.Contains(configData.SqlServerDB))
                    return $"Missing database {configData.SqlServerDB}";

                if (!string.IsNullOrWhiteSpace(configData.DbcFolder) && !configData.DbcFolder.Last().Equals('\\'))
                    configData.DbcFolder += "\\";

                if (!Directory.Exists(configData.DbcFolder))
                    return $"Invalid path {configData.DbcFolder}";

                return null;
            }
            catch (MySqlException e)
            {
                if (skipException)
                    return $"{e.Number}: {e.Message}";

                throw e;
            }
            catch (Exception e)
            {
                if (skipException)
                    return $"{e.Message}";

                throw e;
            }
        }
    }
}
