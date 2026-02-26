using IronhorseInvoiceAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IronhorseInvoiceAssistant.Infrastructure
{

    public static class SettingsSevice
    {

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true
        };

        public static AppSettings Load(AppSettings appSettings)
        {
            throw new NotImplementedException();
        }

        public static AppSettings Save(AppSettings appSettings)
        {
            throw new NotImplementedException();
        }
        
    }
}
