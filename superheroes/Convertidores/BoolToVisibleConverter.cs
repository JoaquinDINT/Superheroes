using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace superheroes.Convertidores
{
        class BoolToVisibleConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                bool? visible = value as bool?;
                Visibility visibilidad = Visibility.Collapsed;

                if (visible == true)
                {
                    visibilidad = Visibility.Visible;
                }

                return visibilidad;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
}
