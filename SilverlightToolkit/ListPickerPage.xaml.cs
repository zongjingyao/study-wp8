using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SilverlightToolkit
{
    public partial class ListPickerPage : PhoneApplicationPage
    {
        public ListPickerPage()
        {
            InitializeComponent();

            //绑定有模板的ListPicker
            List<Cities> source = new List<Cities>();
            source.Add(new Cities() { Name = "Madrid", Country = "ES", Language = "Spanish" });
            source.Add(new Cities() { Name = "Las Vegas", Country = "US", Language = "English" });
            source.Add(new Cities() { Name = "London", Country = "UK", Language = "English" });
            source.Add(new Cities() { Name = "Mexico", Country = "MX", Language = "Spanish" });
            this.listPicker.ItemsSource = source;

            //绑定没有模板的ListPicker
            this.defaultPicker.ItemsSource = new List<string>() { "Madrid", "London", "Mexico" };
        }
    }
}