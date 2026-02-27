using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using IronhorseInvoiceAssistant.Infrastructure;
using IronhorseInvoiceAssistant.Services;

namespace IronhorseInvoiceAssistant.Services
{
    public class JsonServices
    {
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = false // modifying object is allowed
        };

        public static string GetJsonPath()
        {
            return SettingsPath.GetLocalUserSettingsPath();
        }

        public static string ParseJsonObject(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
