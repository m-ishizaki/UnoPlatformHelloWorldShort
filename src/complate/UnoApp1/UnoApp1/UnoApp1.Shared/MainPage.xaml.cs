using System;
using UnoApp1.Shared;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnoApp1
{
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
            var value = e.ClickedItem;

            this.Frame.Navigate(typeof(SecondPage), value);
        }
    }
}
