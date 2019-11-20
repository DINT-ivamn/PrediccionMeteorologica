using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PrediccionMeteorologica
{
    class ImagenConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] prediccion = new string[] { "sol", "nubes", "lluvia", "nieve" };
            string[] imagenes = new string[] { "Recursos/sunny.png", "Recursos/cloudy.png", "Recursos/rain.png", "Recursos/snow.png"};
            string valor = value.ToString();
            int indice = prediccion.ToList().FindIndex(s => s == valor);
            return imagenes[indice];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
