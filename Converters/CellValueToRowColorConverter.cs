using System;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Citadel.Apps.Dashboard.Converters
{
    public class CellValueToRowColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Brush[] brushes = parameter as Brush[];
            if (value != null && value.ToString().Contains("Trade Override Request"))
                return (SolidColorBrush)brushes[0];
            else
                return (SolidColorBrush)brushes[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
