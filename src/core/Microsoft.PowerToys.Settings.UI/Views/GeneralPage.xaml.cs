﻿using Microsoft.PowerToys.Settings.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Microsoft.PowerToys.Settings.UI.Views
{
    public sealed partial class GeneralPage : Page
    {
        public GeneralViewModel ViewModel { get; } = new GeneralViewModel();

        public GeneralPage()
        {
            this.InitializeComponent();
        }
    }
}
