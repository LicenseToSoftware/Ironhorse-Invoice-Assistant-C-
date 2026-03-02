using System.Text.Json;
using IronhorseInvoiceAssistant.Infrastructure.Persistence.Settings;

namespace IronhorseInvoiceAssistant.Infrastructure.Json
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
