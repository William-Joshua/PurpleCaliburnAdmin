using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace PurpleCaliburnAdmin.Converters
{
    public class AccessDeniedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool accessDenied)
            {
                return accessDenied ? Brushes.Black : new SolidColorBrush(color: Color.FromRgb(0x80, 0x80, 0x80));
            }
            return new SolidColorBrush(color: Color.FromRgb(0x80, 0x80, 0x80));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 这个转换通常不需要，因为我们只关心从 bool 到颜色的转换
            throw new NotImplementedException();
        }
    }
}
