using System;
using System.Collections.Generic;
using System.Text;
using TwoWayIPCLibLib;

namespace Microsoft.PowerToys.Settings.UI.Runner
{
    public class Program
    {
        public static ITwoWayIPCManager ipcWrapper { get; set; }
        [System.STAThreadAttribute()]
        public static void Main(string[] args)
        {
            ipcWrapper = new TwoWayIPCManager();
            ipcWrapper.Initialize(args[1], args[0]);
            using (new UI.App())
            {
                App app = new App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
