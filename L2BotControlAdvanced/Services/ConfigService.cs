using L2BotControlAdvanced.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BotControlAdvanced.Services
{
    public class ConfigService : IConfigService
    {
        private string _configPath = "";
        private SavedConfig _config = null;
        public SavedConfig Config {
            get { return _config; }
            private set { }
        }

        public ConfigService()
        {
            SetConfigPath();
            LoadCurrentConfig();
        }

        public void LoadCurrentConfig()
        {
            
            _config = JsonConvert.DeserializeObject<SavedConfig>(File.ReadAllText($"{_configPath}\\SavedConfig.json"));
        }

        public void SaveCurrentConfig()
        {

        }

        public void BackupCurrentConfig()
        {

        }

        public void RestoreCurrentConfigFromBackup()
        {

        }

        private void SetConfigPath()
        {
            var runtimeDirectory = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            runtimeDirectory = runtimeDirectory.Replace("file:///", "");
            _configPath = new DirectoryInfo(Path.GetDirectoryName(runtimeDirectory)).ToString();
        }
    }
}
