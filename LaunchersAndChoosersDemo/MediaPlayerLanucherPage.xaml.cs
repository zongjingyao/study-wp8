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
    public partial class MediaPlayerLanucherPage : PhoneApplicationPage
    {
        public MediaPlayerLanucherPage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //创建一个多媒体的启动器
            MediaPlayerLauncher mpl = new MediaPlayerLauncher();
            //设置播放文件放置的位置属性 
            mpl.Location = MediaLocationType.Install;
            //设置所有控制纽都出现 
            mpl.Controls = MediaPlaybackControls.All;
            //设置出现停止按钮以及暂停按钮 
            mpl.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop;
            //设置播放的文件 
            mpl.Media = new Uri(@"media\123.wmv", UriKind.Relative);
            //启动播放
            mpl.Show(); 
        }
    }
}