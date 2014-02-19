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
    public partial class ConnectionSettingTaskPage : PhoneApplicationPage
    {
        ConnectionSettingsTask connectionSettingsTask;
        public ConnectionSettingTaskPage()
        {
            InitializeComponent();
            //创建一个连接设置任务
            connectionSettingsTask = new ConnectionSettingsTask();
        }

        private void btnWiFi_Click(object sender, RoutedEventArgs e)
        {
            connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.WiFi;
            connectionSettingsTask.Show();
        }

        private void btnBluetooth_Click(object sender, RoutedEventArgs e)
        {
            connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.Bluetooth;
            connectionSettingsTask.Show();
        }

        private void btnCellular_Click(object sender, RoutedEventArgs e)
        {
            connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.Cellular;
            connectionSettingsTask.Show();
        }

        private void btnAirplaneMode_Click(object sender, RoutedEventArgs e)
        {
            connectionSettingsTask.ConnectionSettingsType = ConnectionSettingsType.AirplaneMode;
            connectionSettingsTask.Show();
        }
    }
}