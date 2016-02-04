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

namespace examples
{
    public partial class SliderPage : PhoneApplicationPage
    {
        public SliderPage()
        {
            InitializeComponent();

            //三个slider控件的初始值
            redSlider.Value = 128;
            greenSlider.Value = 128;
            blueSlider.Value = 128;
        }

        private void OnSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //获取调剂的颜色
            Color clr = Color.FromArgb(255, (byte)redSlider.Value,(byte)greenSlider.Value,(byte)blueSlider.Value);
            redText.Text = clr.R.ToString("X2");
            greenText.Text = clr.G.ToString("X2");
            blueText.Text = clr.B.ToString("X2");
            //将3种颜色的混合色设置为椭圆的前景色
            ellipse1.Fill = new SolidColorBrush(clr);
            textBlock1.Text = clr.ToString();
        }
    }
}