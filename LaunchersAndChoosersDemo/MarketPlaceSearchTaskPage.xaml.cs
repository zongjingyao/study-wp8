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
    public partial class MarketPlaceSearchTaskPage : PhoneApplicationPage
    {
        public MarketPlaceSearchTaskPage()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //创建一个市场搜索任务
            MarketplaceSearchTask mst = new MarketplaceSearchTask();
            if (rbMusic.IsChecked == true)
            {//搜索音乐类别
                mst.ContentType = MarketplaceContentType.Music;
            }
            else
            {//搜索应用程序类表
                mst.ContentType = MarketplaceContentType.Applications;
            }
            //搜索的关键字
            mst.SearchTerms = tbxInput.Text;
            //启动搜索
            mst.Show();
        }
    }
}