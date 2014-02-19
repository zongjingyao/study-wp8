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
using System.Windows.Input;

namespace LaunchersAndChoosersDemo
{
    public partial class SavePhoneNumberTaskPage : PhoneApplicationPage
    {
        SavePhoneNumberTask spn;
        public SavePhoneNumberTaskPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //设置文本框为数字输入模式
            tbxPhoneNo.InputScope = new InputScope()
            {
                Names = { new InputScopeName() { NameValue = InputScopeNameValue.TelephoneNumber } }
            };

            spn = new SavePhoneNumberTask();
            spn.Completed += new EventHandler<TaskEventArgs>(spn_Completed);
            spn.PhoneNumber = tbxPhoneNo.Text;
            spn.Show();
        }

        private void spn_Completed(object sender, TaskEventArgs e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                MessageBox.Show("保存成功!");
            }
            else
            {
                MessageBox.Show("保存失败!");
            }
        }
    }
}