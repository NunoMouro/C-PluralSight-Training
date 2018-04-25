using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while(selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius to Fahrenheit or F)ahrenheit to Celsius: ");
                selection = Console.ReadLine();
                double fah = 0, celsius = 0;
                switch(selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the Celsius Temperature: ");
                        fah = TemperatureConverter.CelsiusToFah(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit is: {fah:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the Fahrenheit Temperature: ");
                        celsius = TemperatureConverter.FahToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius is: {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Please try again");
                        break;
                            
                }
            }
        }
    }
}
