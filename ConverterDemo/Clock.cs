using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace ConverterDemo
{
    public class Clock : INotifyPropertyChanged
    {
        int hour, min, sec;
        //属性值改变事件
        public event PropertyChangedEventHandler PropertyChanged;
        
        public Clock()
        {
            //获取当前的时间
            OnTimerTick(null, null);
            //使用定时器来触发时间来改变类的时分秒属性
            //每0.1秒来获取一次当前的时间
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(0.1);
            dt.Tick += OnTimerTick;
            dt.Start();
        }

        //时间触发器
        void OnTimerTick(object sender, EventArgs args)
        {
            DateTime dt = DateTime.Now;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }

        //属性改变事件
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, args);
        }

        //小时属性
        public int Hour
        {
            protected set
            {
                if(value != hour)
                {
                    hour = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Hour"));
                }
            }
            get
            {
                return hour;
            }
        }

        public int Minute
        {
            protected set
            {
                if (value != min)
                {
                    min = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Minute"));
                }
            }
            get
            {
                return min;
            }
        }

        public int Second
        {
            protected set
            {
                if (value != sec)
                {
                    sec = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Second"));
                }
            }
            get
            {
                return sec;
            }
        }

    }
}
