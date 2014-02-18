using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Xml.Linq;

namespace IsolatedStorageFileDemo
{
    public partial class DisplayPage : PhoneApplicationPage
    {
        public DisplayPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            string itemName = "";
            //获取上一页面传递过来的item值
            bool isItemExists = NavigationContext.QueryString.TryGetValue("item", out itemName);
            if(isItemExists)
            {
                pageTitle.Text = itemName;
            }

            using(IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                XElement xml;//定义Linq的XML元素
                //打开本地存储文件
                IsolatedStorageFileStream location = new IsolatedStorageFileStream(itemName, System.IO.FileMode.Open, storage);
                //转化为可读流
                System.IO.StreamReader sr = new System.IO.StreamReader(location);
                //解析流转化为XML
                xml = XElement.Parse(sr.ReadToEnd());

                if(xml.Name.LocalName != null)
                {
                    tbkName.Text = itemName;
                    XAttribute price = xml.Attribute("price");//获取价格
                    tbkPrice.Text = price.Value.ToLower();
                    XAttribute quantity = xml.Attribute("quantity");//获取数量
                    tbkQuantity.Text = quantity.Value.ToLower();
                }

                sr.Dispose();
                location.Dispose();
            }
        }
    }
}