using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UnoApp1.Shared
{
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();

#if __WASM__
            platform.Text = "WASM";
#endif

#if WINDOWS_UWP
           platform.Text = "UWP";
#endif

#if __ANDROID__
            platform.Text = "Android";
#endif

#if __IOS__
           platform.Text = "iOS";
#endif
        }

        private void Button_Click_GoBack(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.DataContext = e.Parameter;

            base.OnNavigatedTo(e);
        }
    }
}
