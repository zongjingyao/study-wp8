using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Windows.Media.Imaging;

namespace examples
{
    public partial class ScrollViewerPage : PhoneApplicationPage
    {
        //往下滚动的定时触发器
        private DispatcherTimer tmrDown;
        //往上滚动的定时触发器
        private DispatcherTimer tmrUp;

        public ScrollViewerPage()
        {
            InitializeComponent();

            //添加图片到ScrollViewer里面的StackPanel中
            for (int i = 0; i <= 30; i++)
            {
                Image imgItem = new Image();
                imgItem.Width = 200;
                imgItem.Height = 200;
                //4张图片循环添加到StackPanel的子节点上
                if (i % 4 == 0)
                {
                    imgItem.Source = (new BitmapImage(new Uri("a.jpg", UriKind.Relative)));
                }
                else if (i % 4 == 1)
                {
                    imgItem.Source = (new BitmapImage(new Uri("b.jpg", UriKind.Relative)));

                }
                else if (i % 4 == 2)
                {
                    imgItem.Source = (new BitmapImage(new Uri("c.jpg", UriKind.Relative)));

                }
                else
                {
                    imgItem.Source = (new BitmapImage(new Uri("d.jpg", UriKind.Relative)));

                }
                this.stkpnlImage.Children.Add(imgItem);
            }

            //初始化tmrDown定时触发器
            tmrDown = new DispatcherTimer();
            //每500毫秒跑一次
            tmrDown.Interval = new TimeSpan(500);
            //加入每次tick的事件
            tmrDown.Tick += tmrDown_Tick;
            //初始化tmrUp定时触发器
            tmrUp = new DispatcherTimer();
            tmrUp.Interval = new TimeSpan(500);
            tmrUp.Tick += tmrUp_Tick;
        }

        void tmrUp_Tick(object sender, EventArgs e)
        {
            //将VerticalOffset -10 将出现图片将往上滚动的效果
            scrollViewer1.ScrollToVerticalOffset(scrollViewer1.VerticalOffset - 10);
        }

        void tmrDown_Tick(object sender, EventArgs e)
        {
            //先停止往上的定时触发器
            tmrUp.Stop();
            //將VerticalOffset +10 将出现图片将往下滚动的效果
            scrollViewer1.ScrollToVerticalOffset(scrollViewer1.VerticalOffset + 10);
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            //先停止往下的定时触发器
            tmrDown.Stop();
            //tmrUp定时触发器开始
            tmrUp.Start();
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            //tmrDown定时触发器开始
            tmrDown.Start();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            //停止定时触发器
            tmrUp.Stop();
            tmrDown.Stop();
        }
    }
}