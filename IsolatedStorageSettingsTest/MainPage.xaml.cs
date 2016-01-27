using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IsolatedStorageSettingsTest.Resources;
using System.IO.IsolatedStorage;

namespace IsolatedStorageSettingsTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        //声明IsolatedStorageSettings实例
        private IsolatedStorageSettings _appSettings;

        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            // 用于本地化 ApplicationBar 的示例代码
            //BuildLocalizedApplicationBar();

            //获取当前应用程序的IsolatedStorageSettings存储
            _appSettings = IsolatedStorageSettings.ApplicationSettings;
            BindKeyList();
        }

        //将当前程序中所有的key值绑定到List上
        private void BindKeyList()
        {
            //清空List控件
            lstKeys.Items.Clear();
            //获取所有key，并添加到List控件上
            foreach(string key in _appSettings.Keys)
            {
                //添加key
                lstKeys.Items.Add(key);
            }
            tbKey.Text = "";
            tbValue.Text = "";
        }

        //保存IsolatedStorageSettings键值
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //检查key输入框是否为空
            if(!String.IsNullOrEmpty(tbKey.Text))
            {
                if(_appSettings.Contains(tbKey.Text))
                {
                    //如果key值已经存在，则修改其值
                    _appSettings[tbKey.Text] = tbValue.Text;
                }
                else
                {
                    //如果不存在，则新增
                    _appSettings.Add(tbKey.Text, tbValue.Text);
                }
                //保存独立存储设置
                _appSettings.Save();
                BindKeyList();
            }
            else
            {
                MessageBox.Show("请输入key值");
            }
        }

        //删除在List中选中的独立存储设置的键
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //如果选中了List中的某项
            if(lstKeys.SelectedIndex > -1)
            {
                //移除这个键的独立存储设置
                _appSettings.Remove(lstKeys.SelectedItem.ToString());
                _appSettings.Save();
                BindKeyList();
            }
        }

        //清空所有的key
        private void deleteall_Click(object sender, RoutedEventArgs e)
        {
            _appSettings.Clear();
            BindKeyList();
        }

        //List控件选中项的事件将选中的键和值显示在上面的文本框中
        private void lstKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
            {
                //获取在List中选择的key
                string key = e.AddedItems[0].ToString();
                //检查独立存储设置是否存在这个key
                if(_appSettings.Contains(key))
                {
                    tbKey.Text = key;
                    tbValue.Text = _appSettings[key].ToString();
                }
            }
        }

        // 用于生成本地化 ApplicationBar 的示例代码
        //private void BuildLocalizedApplicationBar()
        //{
        //    // 将页面的 ApplicationBar 设置为 ApplicationBar 的新实例。
        //    ApplicationBar = new ApplicationBar();

        //    // 创建新按钮并将文本值设置为 AppResources 中的本地化字符串。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // 使用 AppResources 中的本地化字符串创建新菜单项。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}