using System;
using System.IO;
using TwoWayIPCLibLib;

namespace ATLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\\PowerToys\\settings.json");

            Console.WriteLine(fileName.ToString());
            string jsontext = System.IO.File.ReadAllText(fileName);

            Console.WriteLine(jsontext);
            Console.WriteLine("\n");

            dynamic baseSettings = Newtonsoft.Json.JsonConvert.DeserializeObject("{general:{}}");
            baseSettings.general = jsontext;
            var generalSettingsModifiedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(baseSettings);

            dynamic generalSettings = Newtonsoft.Json.JsonConvert.DeserializeObject(generalSettingsModifiedJsonString);
            //generalSettings.general.packaged = true;

            
            Console.WriteLine(generalSettingsModifiedJsonString);


            /*
            ITwoWayIPCManager ipcmanager = new TwoWayIPCManager();
            ipcmanager.Initialize(args[1], args[0]);
            while(true)
            {
                Console.ReadLine();
                ipcmanager.SendMessage("{\"general\":{\"startup\":false,\"run_elevated\":false,\"enabled\":{\"FancyZones\":false,\"PowerRename\":false,\"Shortcut Guide\":false}}}");
                Console.ReadLine();
            }*/
        }
    }
}
