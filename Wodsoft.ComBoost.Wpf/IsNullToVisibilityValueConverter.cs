﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Wodsoft.ComBoost.Wpf
{
    public class IsNullToVisibilityValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (parameter == null)
                return value == null ? Visibility.Visible : Visibility.Collapsed;
            if (parameter is bool)
                if ((bool)parameter)
                    return value == null ? Visibility.Visible : Visibility.Collapsed;
                else
                    return value != null ? Visibility.Visible : Visibility.Collapsed;
            else if (parameter is string)
                if ((string)parameter == "true")
                    return value == null ? Visibility.Visible : Visibility.Collapsed;
                else if ((string)parameter == "false")
                    return value != null ? Visibility.Visible : Visibility.Collapsed;
            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
