using System.IO;
using System.Linq;

namespace SDVWM_Example_Addon.Extension
{
    class Extension_Loader
    {
        Configuration config = new Configuration();

        public bool Load_Configuration()
        {
            string APP_BASE = System.AppDomain.CurrentDomain.BaseDirectory;

            string APP = "StarDewValleyWeatherMachine"; // Name of the Master Application to get data from
            string config_file = "SDVWM.ini";

            string extension_folder = APP_BASE + "Mods" + "\\" + APP;
            string config_directory = APP_BASE + "Mods" + "\\" + APP + "\\" + config_file;


            //File.ReadAllText(filepath);
            if (Directory.Exists(extension_folder))
            {
                if (File.Exists(config_directory))
                {
                    return true;
                }


            }

            return false;

        }


        public string Load_Weather_Summary()
        {
            string APP_BASE = System.AppDomain.CurrentDomain.BaseDirectory;

            string APP = "StarDewValleyWeatherMachine"; // Name of the Master Application to get data from
            string config_file = "SDVWM.ini";

            string extension_folder = APP_BASE + "Mods" + "\\" + APP;
            string config_directory = APP_BASE + "Mods" + "\\" + APP + "\\" + config_file;

            string[] result;

            //File.ReadAllText(filepath);
            if (Directory.Exists(extension_folder))
            {
                if (File.Exists(config_directory))
                {
                    result = File.ReadLines(config_directory).ToArray();

                    config.Weather_Summary = result[0];

                    return config.Weather_Summary;
                }


            }

            return "No weather reported";

        }


    }
}
