using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase4
{
    public static class Temperatura
    {
        // Punto 11
        public static double ConvertirCelsiusFahrenheit(double celsius)
        {
            double GradosFahrenheit = celsius * 2.12;
            return GradosFahrenheit;
        }
        public static double ConvertirFahrenheitCelsius(double fahrenheit)
        {
            double GradosCelsius = fahrenheit / 2.12;
            return GradosCelsius;
        }
    }
}
