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
    public partial class AutoCompleteBoxPage : PhoneApplicationPage
    {
        public AutoCompleteBoxPage()
        {
            InitializeComponent();

            List<string> names = new List<string>();
            string namesString = "Fernando Sucre,Scofield,Alexander Mahone,Theodore Bagwell,Sara Tancredi ,Lincoln Burrows,John Abruzzi,Fluorine";
            foreach (var name in namesString.Split(','))
                names.Add(name);

            acbPeople1.ItemsSource = names;
            acbPeople1.ItemFilter += SearchCountry;
        }

        //全局模糊搜索
        bool SearchCountry(string search,object value)
        {
            if(value != null)
            {
                //如果包含了搜索的字符串则返回true
                if (value.ToString().ToLower().IndexOf(search) > 0)
                    return true;
            }

            //如果不匹配，返回false
            return false;
        }
    }
}