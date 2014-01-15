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
    public partial class TextBoxPage : PhoneApplicationPage
    {
        public TextBoxPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlock1.Text = textBox1.Text;
        }
    }
}