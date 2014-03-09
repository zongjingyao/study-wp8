using System;
using System.ComponentModel;
using BindingDataDemo.Model;
using System.Collections.ObjectModel;

namespace BindingDataDemo.ViewModel
{
    public class FoodViewModel : INotifyPropertyChanged
    {
        //定义食物类的集合
        private ObservableCollection<Food> _allFood;

        //将集合作为ViewModel层的属性
        public ObservableCollection<Food> AllFood
        {
            get
            {
                if (_allFood == null)
                    _allFood = new ObservableCollection<Food>();

                return _allFood;
            }
            set
            {
                if (_allFood != value)
                {
                    _allFood = value;
                    NotifyPropertyChanged("AllFood");
                }
            }
        }

        //定义属性改变事件
        public event PropertyChangedEventHandler PropertyChanged;

        //实现属性改变事情
        public void NotifyPropertyChanged(String propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //初始化ViewModel层的数据
        public FoodViewModel()
        {
            try
            {
                Food item0 = new Food() { Name = "西红柿", IconUri = "Images/Tomato.png", Type = "Healthy", Description = "西红柿的味道不错。" };
                Food item1 = new Food() { Name = "茄子", IconUri = "Images/Beer.png", Type = "NotDetermined", Description = "不知道这个是否好吃。" };
                Food item2 = new Food() { Name = "火腿", IconUri = "Images/fries.png", Type = "Unhealthy", Description = "这是不健康的食品。" };
                Food item3 = new Food() { Name = "三明治", IconUri = "Images/Hamburger.png", Type = "Unhealthy", Description = "肯德基的好吃？" };
                Food item4 = new Food() { Name = "冰激凌", IconUri = "Images/icecream.png", Type = "Healthy", Description = "给小朋友吃的。" };
                Food item5 = new Food() { Name = "Pizza", IconUri = "Images/Pizza.png", Type = "Unhealthy", Description = "这个非常不错。" };
                Food item6 = new Food() { Name = "辣椒", IconUri = "Images/Pepper.png", Type = "Healthy", Description = "我不喜欢吃这东西。" };
                AllFood.Add(item0);
                AllFood.Add(item1);
                AllFood.Add(item2);
                AllFood.Add(item3);
                AllFood.Add(item4);
                AllFood.Add(item5);
                AllFood.Add(item6);
            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show("Exception: " + e.Message);
            }
        }
    }
}
