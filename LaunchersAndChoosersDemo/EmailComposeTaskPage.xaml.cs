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
    public partial class EmailComposeTaskPage : PhoneApplicationPage
    {
        public EmailComposeTaskPage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            // 创建一个EmailComposeTask任务
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            //设置收件人
            emailComposeTask.To = tbxTo.Text;
            //设置邮件的标题
            emailComposeTask.Subject = tbxTitle.Text;
            //设置邮件的内容
            emailComposeTask.Body = tbxBody.Text;
            //发送邮件
            emailComposeTask.Show();
        }
    }
}