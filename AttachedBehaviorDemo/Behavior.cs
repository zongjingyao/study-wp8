using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace AttachedBehaviorDemo
{
    static public class Behavior
    {
        //注册一个附加属性BrushProperty，在XAML中名字为Brush，是Brush类型，在Hover类中，PropertyMetadata初始化元数据
        public static readonly DependencyProperty BrushProperty = DependencyProperty.RegisterAttached(
            "Brush",
            typeof(Brush),
            typeof(Behavior),
            new PropertyMetadata(null, new PropertyChangedCallback(OnHoverBrushChanged)));

        /// 获取Brush的属性值
        public static Brush GetBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BrushProperty);
        }

        /// 设置属性的值
        public static void SetBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BrushProperty, value);
        }

        /// 属性初始化
        private static void OnHoverBrushChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            //获取属性所在的TextBlock控件
            TextBlock control = obj as TextBlock;
            //注册控件的事件
            if (control != null)
            {
                //注册鼠标进入事件
                control.MouseEnter += new MouseEventHandler(OnControlEnter);
                //注册鼠标离开事件
                control.MouseLeave += new MouseEventHandler(OnControlLeave);
            }

        }

        /// 鼠标进入事件
        static void OnControlEnter(object sender, MouseEventArgs e)
        {
            //获取当前的TextBlock控件
            TextBlock control = (TextBlock)e.OriginalSource;
            //设置控件的前景颜色为红色
            control.Foreground = new SolidColorBrush(Colors.Red);
        }

        /// 鼠标离开事件
        static void OnControlLeave(object sender, MouseEventArgs e)
        {
            //获取当前的TextBlock控件
            TextBlock control = (TextBlock)e.OriginalSource;
            //设置控件的前景颜色为当前控件的Brush属性的值
            control.Foreground = GetBrush(control);
        }
    }
}
