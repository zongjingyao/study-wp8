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
    public partial class AddItem : PhoneApplicationPage
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using(IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                XElement item = new XElement(tbName.Text);//创建一个XML元素
                XAttribute price = new XAttribute("price", tbPrice.Text);//创建一个XML属性
                XAttribute quantity = new XAttribute("quantity", tbQuantity.Text);

                item.Add(price, quantity);//将两个属性添加到XML元素上
                //用item新建一个XML的Linq文档
                XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), item);

                //创建一个本地存储的文件流
                IsolatedStorageFileStream location = new IsolatedStorageFileStream(tbName.Text + ".item", System.IO.FileMode.Create, storage);
                //将本地存储文件流转化为可写流
                System.IO.StreamWriter sw = new System.IO.StreamWriter(location);
                //将XML文件 保存到流file上 即已经写入到手机本地存储文件上
                doc.Save(sw);

                sw.Dispose();//关闭可写流
                location.Dispose();//关闭手机本地存储流
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));//返回清单页面
            }
        }
    }
}