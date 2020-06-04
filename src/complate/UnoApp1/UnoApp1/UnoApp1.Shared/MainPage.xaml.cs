﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnoApp1.Shared;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = new MainPageViewModel();
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            await new MessageDialog(textbox1.Text).ShowAsync();
        }

        private void listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value = e.ClickedItem as Spetialty;

            this.Frame.Navigate(typeof(SecondPage), value);
        }
    }
}
