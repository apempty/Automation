using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Configuration
{
    class Config
    {
    public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    public static string GetEnvironment()
        {
            return GetConfigValue("Environment");
         }

    public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }

        public static string GetURL(string applicationName)
        {
            return GetConfigValue($"{applicationName}.{GetEnvironment()}");
        }


    }
}
