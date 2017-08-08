using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long number = long.Parse(Console.ReadLine());

                if(number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                    return;
                }
                else if(number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                    return;
                }

                Console.WriteLine("Windy");
                return;
            }
            catch
            {
                
                Console.WriteLine("Rainy");
            }
        }
    }
}
