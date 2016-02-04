using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using examples.Resources;

namespace examples
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            // 用于本地化 ApplicationBar 的示例代码
            //BuildLocalizedApplicationBar();
        }

        private void btnToButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Button.xaml", UriKind.Relative));
        }

        private void btnToTextBlock_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TextBlockPage.xaml", UriKind.Relative));
        }

        private void btnToTextBox_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TextBoxPage.xaml", UriKind.Relative));
        }

        private void btnToBorder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BorderPage.xaml", UriKind.Relative));
        }

        private void btnToHyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HyperlinkButtonPage.xaml", UriKind.Relative));
        }

        private void btnToRadioButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/RadioButtonPage.xaml", UriKind.Relative));
        }

        private void btnToCheckBox_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CheckBoxPage.xaml", UriKind.Relative));
        }

        private void btnToProgressBar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProgressBarPage.xaml", UriKind.Relative));
        }

        private void btnToScrollViewer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ScrollViewerPage.xaml", UriKind.Relative));
        }

        private void btnToListBox_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListBoxPage.xaml", UriKind.Relative));
        }

        private void btnToSliderPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SliderPage.xaml", UriKind.Relative));
        }

        private void btnToApplicationBar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ApplicationBarPage.xaml", UriKind.Relative));
        }

        // 用于生成本地化 ApplicationBar 的示例代码
        //private void BuildLocalizedApplicationBar()
        //{
        //    // 将页面的 ApplicationBar 设置为 ApplicationBar 的新实例。
        //    ApplicationBar = new ApplicationBar();

        //    // 创建新按钮并将文本值设置为 AppResources 中的本地化字符串。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // 使用 AppResources 中的本地化字符串创建新菜单项。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}