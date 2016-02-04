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
using System.Windows.Media.Imaging;

namespace LaunchersAndChoosersDemo
{
    public partial class CameraCaptureTaskPage : PhoneApplicationPage
    {
        CameraCaptureTask cct; 

        public CameraCaptureTaskPage()
        {
            InitializeComponent();
        }

        private void btnShot_Click(object sender, RoutedEventArgs e)
        {
            //创建一个捕获相机拍照的选择器
            cct = new CameraCaptureTask();
            //注册选择器完成的事件
            cct.Completed += new EventHandler<PhotoResult>(cct_Completed); 
            //启动拍照选择器 
            cct.Show(); 
        }

        private void cct_Completed(object sender, PhotoResult e)
        {
            //判断结果是否成功 
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage bmpSource = new BitmapImage();
                bmpSource.SetSource(e.ChosenPhoto);
                image1.Source = bmpSource;
            }
            else
            {
                image1.Source = null;
            }
        }
    }
}