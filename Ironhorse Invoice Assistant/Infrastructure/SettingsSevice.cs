using IronhorseInvoiceAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IronhorseInvoiceAssistant.Services;

namespace IronhorseInvoiceAssistant.Infrastructure
{

    public static class SettingsSevice
    {

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = false // modifying object is allowed
        };

        public static AppSettingsModel? Load()
        {
            var json = File.ReadAllText(SettingsPath.GetLocalUserSettingsPath());

            AppSettingsModel? settings = JsonSerializer.Deserialize<AppSettingsModel>(json, JsonOptions);
            
            return settings;
        }

        public static AppSettingsModel Save()
        {
            throw new NotImplementedException();
        }
        
    }
}
