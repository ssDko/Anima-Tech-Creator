
using System.Collections;
using System.Globalization;
using System.Windows.Data;

namespace AnimaTechCreator.Converters
{
    public class ListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is IEnumerable list)
            {
                return string.Join(", ", list.Cast<object>().Select(item => item.ToString()));
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
