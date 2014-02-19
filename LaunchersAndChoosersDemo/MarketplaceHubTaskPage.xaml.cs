using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace LaunchersAndChoosersDemo
{
    public partial class MarketplaceHubTaskPage : PhoneApplicationPage
    {
        public MarketplaceHubTaskPage()
        {
            InitializeComponent();
        }

        private void btnApp_Click(object sender, RoutedEventArgs e)
        {
            //创建一个进入应用市场的任务
            MarketplaceHubTask mht = new MarketplaceHubTask();
            //设置为应用程序类别
            mht.ContentType = MarketplaceContentType.Applications;
            //启动任务
            mht.Show();
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            //创建一个进入应用市场的任务
            MarketplaceHubTask mht = new MarketplaceHubTask();
            //设置为音乐类别
            mht.ContentType = MarketplaceContentType.Music;
            //启动任务
            mht.Show();
        }
    }
}