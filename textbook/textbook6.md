[Top](./top.md)  

# ふたつめの画面

このページからは画面遷移を作り始めます。  
まずはこのページで遷移先の画面を作ります。

# SecondPage 画面の追加

**SecondPage.xaml** を開いて次のように編集します。

```xml
<Page
    x:Class="UnoApp1.Shared.SecondPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:UnoApp1.Shared"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

    <Grid>
        <StackPanel>
            <Image Source="{Binding Image}" Height="100"/>
            <TextBlock Text="{Binding Name}" FontSize="20"/>
            <TextBlock Text="解説"/>
            <TextBlock Text="{Binding Description}"/>
            <Button Content="&lt; GoBack" Click="Button_Click_GoBack"/>
        </StackPanel>
    </Grid>
</Page>
```
**SecondPage.xaml.cs** に前画面で選択された値の表示と、**戻る** 動作を追加します。

```cs
private void Button_Click_GoBack(object sender, RoutedEventArgs e)
{
    this.Frame.GoBack();
}

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    this.DataContext = e.Parameter;
    base.OnNavigatedTo(e);
}
```

**SecondPage.xaml.cs** 全体は次のようになります。

```cs
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
```

ふたつめの画面のコードができましたが、実行結果は一旦おあずけです。まずは、ひとつめの画面に画面遷移のコードを追加しなければこの画面を見ることはできません。  

次ページで、ひとつめの画面に画面遷移のコードを追加します。

[< | 前へ](./textbook5.md) | [次へ | >](./textbook7.md)
