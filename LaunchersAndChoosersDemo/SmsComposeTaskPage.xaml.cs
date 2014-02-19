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
    public partial class SmsComposeTaskPage : PhoneApplicationPage
    {
        public SmsComposeTaskPage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //创建发送短信的任务
            SmsComposeTask sct = new SmsComposeTask();
            sct.To = tbxTo.Text;
            sct.Body = tbxBody.Text;
            sct.Show();
        }
    }
}