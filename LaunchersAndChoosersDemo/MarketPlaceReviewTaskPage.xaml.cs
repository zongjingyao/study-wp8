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
    public partial class MarketPlaceReviewTaskPage : PhoneApplicationPage
    {
        public MarketPlaceReviewTaskPage()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //创建一个查看本应用程序简介和评论的任务
            try
            {
                MarketplaceReviewTask mpr = new MarketplaceReviewTask();
                mpr.Show();
            }
            catch
            {
                MessageBox.Show("找不到应用程序！");
            }
        }
    }
}