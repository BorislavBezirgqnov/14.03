﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{celsius:F2}");
        }

        private static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
