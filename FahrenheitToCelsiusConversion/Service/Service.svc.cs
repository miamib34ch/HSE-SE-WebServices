using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FahrenheitToCelsiusConversion
{
    // Реализация службы
    public class Service : IService
    {
        public double FahrenheitToCelsius(double farenheitDegrees) => 5.0 / 9 * (farenheitDegrees - 32);
        public double CelsiusToFahrenheit(double celsiusDegrees) => 9.0 / 5 * celsiusDegrees + 32;
    }
}
