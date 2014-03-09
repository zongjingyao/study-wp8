using System;
using System.Windows.Input;
using System.ComponentModel;
using Microsoft.Expression.Interactivity.Core;

namespace CommandDemo.ViewModel
{
    public class RadiusViewModel : INotifyPropertyChanged
    {
        //圆的半径
        private Double radius;
        //定义属性改变事件
        public event PropertyChangedEventHandler PropertyChanged;

        //初始化ViewModel
        public RadiusViewModel()
        {
            Radius = 0;
            //注册小、中、大的单击Command事件
            MinRadius = new ActionCommand(p => Radius = 100);
            MedRadius = new ActionCommand(p => Radius = 200);
            MaxRadius = new ActionCommand(p => Radius = 300);
        }

        //定义小按钮的Command接口
        public ICommand MinRadius
        {
            get;
            private set;
        }

        //定义中按钮的Command接口
        public ICommand MedRadius
        {
            get;
            private set;
        }

        //定义大按钮的Command接口
        public ICommand MaxRadius
        {
            get;
            private set;
        }

        //半径属性
        public Double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                OnPropertyChanged("Radius");
            }
        }

        //实现属性改变事件
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        
        
    }
}
