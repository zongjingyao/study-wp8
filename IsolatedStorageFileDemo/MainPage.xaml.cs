using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IsolatedStorageFileDemo.Resources;
using System.IO.IsolatedStorage;

namespace IsolatedStorageFileDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 构造函数
        public MainPage()
        {
            InitializeComponent();

            // 用于本地化 ApplicationBar 的示例代码
            //BuildLocalizedApplicationBar();

            //加载页面触发Loaded事件
            Loaded += (object sender, RoutedEventArgs e) =>
            {
                Files.Items.Clear();//先清空一下ListBox的数据
                //获取应用程序的本地存储文件
                using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    //获取并循环 *.item的存储文件
                    foreach (string filename in storage.GetFileNames("*.item"))
                    {
                        //动态构建一个Grid
                        Grid a = new Grid();
                        //定义第一列
                        ColumnDefinition col = new ColumnDefinition();
                        GridLength gl = new GridLength(200);
                        col.Width = gl;
                        a.ColumnDefinitions.Add(col);
                        //定义第二列
                        ColumnDefinition col2 = new ColumnDefinition();
                        GridLength gl2 = new GridLength(200);
                        col2.Width = gl;
                        a.ColumnDefinitions.Add(col2);
                        //添加一个TextBlock现实文件名 到第一列
                        TextBlock txbx = new TextBlock();
                        txbx.Text = filename;
                        Grid.SetColumn(txbx, 0);
                        //添加一个HyperlinkButton链接到购物详细清单页面 这是第二列
                        HyperlinkButton btn = new HyperlinkButton();
                        btn.Width = 200;
                        btn.Content = "查看详细";
                        btn.Name = filename;
                        btn.NavigateUri = new Uri("/DisplayPage.xaml?item=" + filename, UriKind.Relative);//传递文件名到商品详细页面

                        Grid.SetColumn(btn, 1);

                        a.Children.Add(txbx);
                        a.Children.Add(btn);

                        Files.Items.Add(a);
                    }
                }
            };
        }

        private void New_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddItem.xaml", UriKind.Relative));
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