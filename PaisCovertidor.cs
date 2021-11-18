using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class PaisCovertidor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string pais = (string)value;
            string ruta = "";
            switch (pais)
            {
                case "Americana":
                    ruta = "./assets/united_states.png";
                    break;
                case "China":
                    ruta = "./assets/china.png";
                    break;
                case "Mexicana":
                    ruta = "./assets/mexico.png";
                    break;
            }
            return ruta;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
