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
    public partial class PhoneCallTaskPage : PhoneApplicationPage
    {
        public PhoneCallTaskPage()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            //创建拨打电话任务
            PhoneCallTask pct = new PhoneCallTask();
            pct.DisplayName = "未知";
            pct.PhoneNumber = tbxPhoneNo.Text;
            pct.Show();
        }
    }
}