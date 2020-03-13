using System;
using System.IO;
using TwoWayIPCLibLib;

namespace ATLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\\PowerToys\\settings.json");

                Console.WriteLine(fileName.ToString());
                string jsontext = System.IO.File.ReadAllText(fileName);

                Console.WriteLine(jsontext);
                Console.WriteLine("\n");

                dynamic baseSettings = Newtonsoft.Json.JsonConvert.DeserializeObject("{general:{}}");
                baseSettings.general = jsontext;
                string generalSettingsModifiedJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(baseSettings);

                generalSettingsModifiedJsonString = generalSettingsModifiedJsonString.Replace("\\r\\n", "").Replace("\\", "").Replace("  ", "");
                Console.WriteLine(generalSettingsModifiedJsonString);

                ITwoWayIPCManager ipcmanager = new TwoWayIPCManager();
                ipcmanager.Initialize(args[1], args[0]);
                while (true)
                {
                    Console.ReadLine();
                    ipcmanager.SendMessage("{\"general\":{\"startup\":true,\"run_elevated\":true,\"enabled\":{\"FancyZones\":true,\"PowerRename\":true,\"Shortcut Guide\":true}}}");
                    //ipcmanager.SendMessage(generalSettingsModifiedJsonString);
                    Console.WriteLine("Message sent");
                    Console.ReadLine();
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
