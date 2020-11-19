using System;
using System.Configuration;
using System.Linq;

namespace StockInfo
{
    public static class ConfigHelper
    {
        public static string GetCodes()
        {
            try
            {
                return ConfigurationManager.AppSettings["Codes"] ?? "";
            }
            catch
            {
                return "";
            }
        }

        public static bool SaveCodes(string Value)
        {
            try
            {
                Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (!conf.AppSettings.Settings.AllKeys.Contains("Codes"))
                    conf.AppSettings.Settings.Add("Codes", Value);
                else
                    conf.AppSettings.Settings["Codes"].Value = Value;
                conf.Save();
                ConfigurationManager.RefreshSection("appSettings"); 
                return true;
            }
            catch { return false; }
        }
    }
}
