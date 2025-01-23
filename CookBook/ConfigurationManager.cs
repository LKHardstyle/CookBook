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
        public static JObject LoadThemeConfig(int ?theme=1)
        {
            string themePath;
            switch (theme)
            {
                case 1:
                    themePath = "themeConfig.json";
                    break;
                case 2:
                    themePath = "themeConfig2.json";
                    break;
                case 3:
                    themePath = "themeConfig3.json";
                    break;
                case 4:
                    themePath = "themeConfig4.json";
                    break;
                default:
                    themePath = "themeConfig.json";
                    break;
            }
                        
            if (File.Exists(themePath)) 
            {
                string config = File.ReadAllText(themePath);
                return JObject.Parse(config);
            }
            return null;
        }
    }
}
