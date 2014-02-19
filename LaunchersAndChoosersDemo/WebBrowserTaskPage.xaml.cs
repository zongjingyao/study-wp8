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
    public partial class WebBrowserTaskPage : PhoneApplicationPage
    {
        public WebBrowserTaskPage()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask wbt = new WebBrowserTask();
            wbt.URL = tbxUrl.Text;
            wbt.Show();
        }
    }
}