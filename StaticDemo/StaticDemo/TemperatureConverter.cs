using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class TemperatureConverter
    {
        public static double CelsiusToFah(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fah = (celsius * 9 / 5) + 32;
            return fah;
        }

        public static double FahToCelsius(string tempFah)
        {
            double fah = Double.Parse(tempFah);
            double celsius = (fah - 32) * 5 / 9;
            return celsius;
        }
    }
}
