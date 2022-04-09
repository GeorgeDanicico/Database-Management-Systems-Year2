using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Assignment1.Service
{
    public class AppConfig
    {
        public string connString { get; }
        public string table1 { get; }
        public string table2 { get; }
        public string query1 { get; }
        public string query2 { get; }
        public string keyName { get; }
        public string columnFK { get; }

        public AppConfig()
        {
            connString = ConfigurationManager.AppSettings.Get("connectionString");
            table1 = ConfigurationManager.AppSettings.Get("table1");
            table2 = ConfigurationManager.AppSettings.Get("table2");
            query1 = ConfigurationManager.AppSettings.Get("query1");
            query2 = ConfigurationManager.AppSettings.Get("query2");
            keyName = ConfigurationManager.AppSettings.Get("keyName");
            columnFK = ConfigurationManager.AppSettings.Get("columnFK");
         }
    }
}
