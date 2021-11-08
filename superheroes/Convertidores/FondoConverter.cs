using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace superheroes.Convertidores
{
    class FondoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? heroe = value as bool?;
            Brush resultado = Brushes.PaleGreen;

            if (heroe == false)
            {
                resultado = Brushes.IndianRed;
            }

            return resultado;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
