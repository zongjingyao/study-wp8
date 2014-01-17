using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace examples
{
    public partial class ApplicationBarPage : PhoneApplicationPage
    {
        public ApplicationBarPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            textBlock1.Text = "你单击了浏览器菜单";
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            textBlock1.Text = "你单击了电话菜单";
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            textBlock1.Text = "你单击了关于菜单";
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            textBlock1.Text = "你单击了MenuItem 1菜单";
        }

        private void ApplicationBarMenuItem_Click_1(object sender, EventArgs e)
        {
            textBlock1.Text = "你单击了MenuItem 2菜单";
        }

        private void ApplicationBar_StateChanged(object sender, ApplicationBarStateChangedEventArgs e)
        {
            textBlock1.Text = "你打开了Menu菜单列表";
        }
    }
}