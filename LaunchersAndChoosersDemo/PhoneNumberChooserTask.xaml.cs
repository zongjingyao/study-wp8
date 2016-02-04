using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace LaunchersAndChoosersDemo
{
    public partial class PhoneNumberChooserTask : PhoneApplicationPage
    {
        PhoneNumberChooserTask pnc;
        
        public PhoneNumberChooserTask()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            //创建一个选择电话号码的选择器 
            pnc = new PhoneNumberChooserTask();
            //注册选择器完成的事件
            pnc.Completed += new EventHandler<PhoneNumberResult>(pnc_Completed);
            
        }

        private void pnc_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                tbxNumber.Text = e.PhoneNumber;
            }
        }
    }
}