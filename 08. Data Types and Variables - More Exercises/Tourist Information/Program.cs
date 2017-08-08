using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());

            switch (imperialUnit)
            {
                case "miles": Console.WriteLine($"{valueToConvert} {imperialUnit} = {(valueToConvert * 1.6):F2} kilometers"); break;
                case "inches": Console.WriteLine($"{valueToConvert} {imperialUnit} = {(valueToConvert * 2.54):F2} centimeters"); break;
                case "feet": Console.WriteLine($"{valueToConvert} {imperialUnit} = {(valueToConvert * 30):F2} centimeters"); break;
                case "yards": Console.WriteLine($"{valueToConvert} {imperialUnit} = {(valueToConvert * 0.91):F2} meters"); break;
                case "gallons": Console.WriteLine($"{valueToConvert} {imperialUnit} = {(valueToConvert * 3.8):F2} liters"); break;
            }
        }
    }
}
