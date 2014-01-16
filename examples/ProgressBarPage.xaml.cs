using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.ComponentModel;
using System.Threading;

namespace examples
{
    public partial class ProgressBarPage : PhoneApplicationPage
    {
        //定义一个后台处理类
        private BackgroundWorker backgroundWorker;

        public ProgressBarPage()
        {
            InitializeComponent();
            //第一次进入页面，设置进度条为不可见
            progressBar1.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void begin_Click(object sender, RoutedEventArgs e)
        {
            //设置进度条为可见
            progressBar1.Visibility = System.Windows.Visibility.Visible;
            
            if (radioButton1.IsChecked == true)
            {
                //设置进度条为不可重复模式
                progressBar1.IsIndeterminate = false;
                //创建一个后台处理类的对象
                backgroundWorker = new BackgroundWorker();
                //调用 RunWorkerAsync后台操作时引发此事件，即后台要处理的事情写在这个事件里面
                backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                //当后台操作完成事件
                backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                //当处理进度（ReportProgress）被激活后，进度的改变将触发ProgressChanged事件
                backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                //设置为可报告进度情况的后台处理
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                //设置进度条的值为0
                progressBar1.Value = 0;
                //设置进度条为重复模式
                progressBar1.IsIndeterminate = true;
            } 
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            //隐藏进度条
            progressBar1.Visibility = System.Windows.Visibility.Collapsed;
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Dispatcher.BeginInvoke(() =>
            {
                //把进度改变的值赋值给progressBar1进度条的值
                progressBar1.Value = e.ProgressPercentage;
            }
         );
        }
        //后台操作完成
        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispatcher.BeginInvoke(() =>
            {
                //隐藏进度条
                progressBar1.Visibility = System.Windows.Visibility.Collapsed;
            }
            );

        }
        //后台操作处理
        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < 100; i++)
            {
                i += 20;
                //赋值当前进度的值，同时会触发进度改变事件
                backgroundWorker.ReportProgress(i);
                //为了能看到进度条的变化效果，这里用进程暂停了1秒
                Thread.Sleep(1000);
            }
        }
    }
}