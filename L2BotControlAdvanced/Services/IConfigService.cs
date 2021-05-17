using L2BotControlAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2BotControlAdvanced.Services
{
    public interface IConfigService
    {
        SavedConfig Config { get; }
        void LoadCurrentConfig();
        void SaveCurrentConfig();
        void BackupCurrentConfig();
        void RestoreCurrentConfigFromBackup();
    }
}
