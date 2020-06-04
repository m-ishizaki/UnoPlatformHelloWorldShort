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

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace UnoApp1.Shared
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
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
