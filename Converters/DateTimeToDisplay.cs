using System;
using System.Globalization;
using System.Windows.Data;

namespace Citadel.Apps.Dashboard.Converters
{
    [ValueConversion(typeof(DateTime), typeof(string))]
    public class DateTimeToDisplay : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var fieldValue = (DateTime)value;
                if (fieldValue == default(DateTime))
                    return null;

                return fieldValue.ToString("MM/dd/yyyy HH:mm:ss tt");
            }
            catch
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
