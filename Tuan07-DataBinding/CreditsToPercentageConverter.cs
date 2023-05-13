using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Tuan07_DataBinding
{
    public class CreditsToPercentageConverter : IValueConverter
    {
        public int Maximum { get; set; } = 100;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = (int)value;
            double percentage = (number * 1.0) / Maximum;
            string result = string.Format("{0:0.00%}", percentage);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
