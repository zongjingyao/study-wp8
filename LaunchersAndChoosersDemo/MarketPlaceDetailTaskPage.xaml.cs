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
    public partial class MarketPlaceDetailTaskPage : PhoneApplicationPage
    {
        public MarketPlaceDetailTaskPage()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //创建一个查看应用程序详细的任务
                MarketplaceDetailTask mdt = new MarketplaceDetailTask();
                //只能设定为Applcations 
                mdt.ContentType = MarketplaceContentType.Applications;
                //当没有指定值则会以目前的应用程式为目标 
                //如果格式检查不符合GUID 的格式则会丢出exception 
                mdt.ContentIdentifier = tbxID.Text;
                //启动任务
                mdt.Show();
            }
            catch
            {
                MessageBox.Show("找不到应用程序！");
            }
        }
    }
}