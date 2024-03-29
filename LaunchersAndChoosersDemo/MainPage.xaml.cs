﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LaunchersAndChoosersDemo.Resources;

namespace LaunchersAndChoosersDemo
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

        private void btnEamilComposeTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EmailComposeTaskPage.xaml", UriKind.Relative));
        }

        private void btnPhoneCallTaskk_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PhoneCallTaskPage.xaml", UriKind.Relative));
        }

        private void btnSearchTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SearchTaskPage.xaml", UriKind.Relative));
        }

        private void btnSmsComposeTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SmsComposeTaskPage.xaml", UriKind.Relative));
        }

        private void btnWebBrowserTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WebBrowserTaskPage.xaml", UriKind.Relative));
        }

        private void btnMediaPlayerLanucherTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MediaPlayerLanucherPage.xaml", UriKind.Relative));
        }

        private void btnMarketPlaceDetailTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MarketPlaceDetailTaskPage.xaml", UriKind.Relative));
        }

        private void btnMarketPlaceHubTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MarketPlaceHubTaskPage.xaml", UriKind.Relative));
        }

        private void btnMarketPlaceReviewTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MarketPlaceReviewTaskPage.xaml", UriKind.Relative));
        }

        private void btnMarketPlaceSearchTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MarketPlaceSearchTaskPage.xaml", UriKind.Relative));
        }

        private void btnMapsTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapsTaskPage.xaml", UriKind.Relative));
        }

        private void btnConnectionSettingTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConnectionSettingTaskPage.xaml", UriKind.Relative));
        }

        private void btnCameraCaptureTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CameraCaptureTaskPage.xaml", UriKind.Relative));
        }

        private void btnSavePhoneNumberTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SavePhoneNumberTaskPage.xaml", UriKind.Relative));
        }

        private void btnPhoneNumberChooserTask_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PhoneNumberChooserTaskPage.xaml", UriKind.Relative));
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