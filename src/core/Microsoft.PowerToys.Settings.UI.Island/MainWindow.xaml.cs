using System;
using System.Windows;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using Microsoft.PowerToys.Settings.UI.Controls;
using Microsoft.PowerToys.Settings.UI.Views;

namespace Microsoft.PowerToys.Settings.UI.Runner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
            // Hook up x:Bind source.
            WindowsXamlHost windowsXamlHost = sender as WindowsXamlHost;
            ShellPage userControl = windowsXamlHost.GetUwpInternalObject() as ShellPage;
            //Program.ipcWrapper.SendMessage("{\"general\":{\"startup\":true,\"run_elevated\":true,\"enabled\":{\"FancyZones\":true,\"PowerRename\":true,\"Shortcut Guide\":true}}}");
            if (userControl != null)
            {
                //userControl.XamlIslandMessage = this.WPFMessage;

            }
        }

        public string WPFMessage
        {
            get
            {
                return "Binding from WPF to UWP XAML";
            }
        }
    }
}
