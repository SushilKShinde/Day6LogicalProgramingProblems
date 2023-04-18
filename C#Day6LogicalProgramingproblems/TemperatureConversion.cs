using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day6LogicalProgramingproblems
{
    internal class TemperatureConversion
    {

        public static void ConvertCelsiusTofahrenheit()
        {
            Console.WriteLine("Enter the temperature in degree Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;   // Converts degree celcius to fahrenheit
            Console.WriteLine("Temperature in degree Fahrenheit is {0}", fahrenheit);
        }

        public static void  ConvertFahrenheitToCelcius()
        {
            Console.WriteLine("\nEnter the temperature in degree fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9; // Converts degree fahrenheit to celcius
            Console.WriteLine("Temperature in degree celsius is {0}", celsius);
        }
    }
}
