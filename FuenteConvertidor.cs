using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class FuenteConvertidor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string pais = (string)value;
            string fuente = "";
            switch (pais)
            {
                case "Americana":
                    fuente = "Slim Summer";
                    break;
                case "China":
                    fuente = "Chinese Wok Food St";
                    break;
                case "Mexicana":
                    fuente = "Taco Salad";
                    break;
            }
            return fuente;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
