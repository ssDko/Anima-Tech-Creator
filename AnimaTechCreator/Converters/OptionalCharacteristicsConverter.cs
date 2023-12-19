using AnimaTechCreator.Common;
using System.Globalization;
using System.Windows.Data;

namespace AnimaTechCreator.Converters
{
    public class OptionalCharacteristicsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is IEnumerable<OptionalCharacteristic> characteristics)
            {
                return string.Join(", ", characteristics.Cast<OptionalCharacteristic>().Select(item => item.Characteristic + " +" + item.AddedCost));
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
