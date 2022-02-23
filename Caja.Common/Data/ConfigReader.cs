using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace App.Common
{
    public class KeyConfig
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public static class ConfigReader
    {
        
#if DEBUG
        private static string RutaBase => AppDomain.CurrentDomain.BaseDirectory.SubstringTo("\\bin\\") + "\\";
#else
        private static string RutaBase => AppDomain.CurrentDomain.BaseDirectory;
#endif
        private static List<KeyConfig> Keys { get; set; }
                      
        public static string DataBase => GetKey("DataBase");

        public static string ApiLicencia => GetKey("ApiLicencia");

        private static void ReadConfig()
        {
            var vJson = "";
            var vRutaConfig = $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\ConfiguracionApp.json";

            using (StreamReader file = new StreamReader(vRutaConfig))
            {
                string linea;

                while ((linea = file.ReadLine()) != null)
                    vJson += linea;

                file.Close();
            }

            Keys = JsonConvert.DeserializeObject<List<KeyConfig>>(vJson);
        }

        private static string GetKeyRuta(string key)
        {
            ReadConfig();
            var result = Keys.FirstOrDefault(x => x.Key == key);

            if (result == null)
                return "";
            else
                return $"{RutaBase}{result.Value}";
        }

        private static string GetKey(string key)
        {
            ReadConfig();
            var result = Keys.FirstOrDefault(x => x.Key == key);

            if (result == null)
                return "";
            else
                return result.Value;
        }
    }
}
