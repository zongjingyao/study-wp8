using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace examples
{
    public partial class TextBlockPage : PhoneApplicationPage
    {
        public TextBlockPage()
        {
            InitializeComponent();

            //在cs页面动态生成TextBlock控件
            TextBlock txtBlock = new TextBlock();
            txtBlock.Height = 50;
            txtBlock.Width = 200;
            txtBlock.Text = "在cs页面动态生成TextBlock";
            txtBlock.Foreground = new SolidColorBrush(Colors.Blue);
            ContentPanel.Children.Add(txtBlock);
        }
    }
}