/*
Write a C# code to Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion.
°C = [(°F-32)×5]/9.
°F = °C×(9/5)+32
*/
using System;

namespace Zzz
{
    class Program
    {
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * (9 / 5)) + 32;
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * (5 / 9);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter value in celsius : ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit : " + CelsiusToFahrenheit(celsius));

            Console.Write("Enter value in fahrenheit : ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius : " + FahrenheitToCelsius(celsius));

            Console.ReadKey();
        }
    }
}
