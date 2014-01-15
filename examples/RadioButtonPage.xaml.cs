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
    public partial class RadioButtonPage : PhoneApplicationPage
    {
        public RadioButtonPage()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (a.IsChecked == true)
                answer.Text = a.Content.ToString();
            else if (b.IsChecked == true)
                answer.Text = b.Content.ToString();
            else if (c.IsChecked == true)
                answer.Text = c.Content.ToString();
            else
                answer.Text = d.Content.ToString();
        }
    }
}