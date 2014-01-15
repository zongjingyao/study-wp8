using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace examples
{
    public partial class BorderPage : PhoneApplicationPage
    {
        public BorderPage()
        {
            InitializeComponent();

            //动态填充brdTest里面的子元素
            Rectangle rectBlue = new Rectangle();
            rectBlue.Width = 1000;
            rectBlue.Height = 1000;
            SolidColorBrush scBrush = new SolidColorBrush(Colors.Blue);
            rectBlue.Fill = scBrush;
            this.brdTest.Child = rectBlue;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //0表示完全透明的 1表示完全显示出来
            TextBorder.BorderBrush.Opacity = 1;
        }
    }
}