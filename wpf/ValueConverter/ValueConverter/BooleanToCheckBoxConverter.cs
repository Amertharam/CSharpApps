using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace ValueConverter
{
    class BooleanToCheckBoxConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CheckBox check = new CheckBox();
            check.IsChecked = true;
            if ( value == null || (value as CheckBox).IsChecked == false)
            {
                check.IsChecked = false; 
            }
            return check.IsChecked;            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
