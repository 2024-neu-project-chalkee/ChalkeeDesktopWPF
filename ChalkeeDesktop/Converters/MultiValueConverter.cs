using System;
using System.Globalization;
using System.Windows.Data;

namespace ChalkeeDesktop.Converters
{
    public class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new string[] { values[0]?.ToString() ?? "", values[1]?.ToString() ?? "" };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}