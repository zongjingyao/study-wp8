using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Reflection;

namespace CommandDemo.Command
{
    public class ExecuteCommandAction : TriggerAction<FrameworkElement>
    {
        //注册一个附加Command
        public static readonly DependencyProperty CommandNameProperty =
             DependencyProperty.Register("CommandName", typeof(string), typeof(ExecuteCommandAction), null);

        //注册一个附加Command参数
        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.Register("CommandParameter", typeof(object), typeof(ExecuteCommandAction), null);

        //重载Invoke方法
        protected override void Invoke(object parameter)
        {
            if (AssociatedObject == null)
                return;

            ICommand command = null;

            var dataContext = AssociatedObject.DataContext;

            foreach (var info in dataContext.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (IsCommandProperty(info) && String.Equals(info.Name, CommandName, StringComparison.Ordinal))
                {
                    command = (ICommand)info.GetValue(dataContext, null);
                    break;
                }
            }

            if ((command != null) && command.CanExecute(CommandParameter))
            {
                command.Execute(CommandParameter);
            }
        }

        //判断Command属性
        private static bool IsCommandProperty(PropertyInfo property)
        {
            return typeof(ICommand).IsAssignableFrom(property.PropertyType);
        }

        //CommandName属性
        public string CommandName
        {
            get
            {
                return (string)GetValue(CommandNameProperty);
            }
            set
            {
                SetValue(CommandNameProperty, value);
            }
        }

        //CommandParameter属性
        public object CommandParameter
        {
            get
            {
                return GetValue(CommandParameterProperty);
            }
            set
            {
                SetValue(CommandParameterProperty, value);
            }
        }
    }
}
