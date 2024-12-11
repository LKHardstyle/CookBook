using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    public static class ConfigurationManager
    {
        public static JObject LoadThemeConfig()
        {
            if (File.Exists("themeConfig.json"))
            {
                string config = File.ReadAllText("themeConfig.json");
                return JObject.Parse(config);
            }
            return null;
        }
    }
}
