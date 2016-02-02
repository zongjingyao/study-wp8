using System;
using System.Globalization;
using System.Windows.Data;

namespace ConverterDemo
{
    public class HoursToDayStringConverter : IValueConverter
    {
        //定义转换方法
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Int16.Parse(value.ToString()) < 12)
            {
                return "尊敬的用户，上午好。";
            }
            else if (Int16.Parse(value.ToString()) > 12)
            {
                return "尊敬的用户，下午好。";
            }
            else
            {
                return "尊敬的用户，中午好。";
            }
        }

        //定义反向转换的方法
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DateTime.Now.Hour;
        }
    }
}
