﻿using System;
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
    public partial class SearchTaskPage : PhoneApplicationPage
    {
        public SearchTaskPage()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchTask st = new SearchTask();
            st.SearchQuery = tbxSearch.Text;
            st.Show();
        }
    }
}