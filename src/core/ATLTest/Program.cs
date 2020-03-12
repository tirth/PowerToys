using System;
using TwoWayIPCLibLib;

namespace ATLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ITwoWayIPCManager ipcmanager = new TwoWayIPCManager();
            ipcmanager.SendMessage("Hellow there from DLL");
            ipcmanager.StartIPC();
        }
    }
}
