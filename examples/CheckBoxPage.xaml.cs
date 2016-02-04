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
    public partial class CheckBoxPage : PhoneApplicationPage
    {
        public CheckBoxPage()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            //第一次进入页面的时候checkBox2还没有初始化，所以必须先判断一下checkBox2是否为null
            if (checkBox2 != null)
            {
                checkBox2.Content = "Checked";
            }
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (checkBox2 != null)
            {
                checkBox2.Content = "Unchecked";
            }
        }
    }
}