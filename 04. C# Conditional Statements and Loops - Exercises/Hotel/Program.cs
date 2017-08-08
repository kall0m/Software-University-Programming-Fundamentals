using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            switch (month)
            {
                case "May":
                case "October": studioPrice = 50; doublePrice = 65; suitePrice = 75; break;
                case "June":
                case "September": studioPrice = 60; doublePrice = 72; suitePrice = 82; break;
                case "July":
                case "August":
                case "December": studioPrice = 68; doublePrice = 77; suitePrice = 89; break;
            }

            if ((month == "May" || month == "October") && nights > 7)
            {
                studioPrice *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                doublePrice *= 0.9;
            }
            else if ((month == "July" || month == "August" || month == "September") && nights > 14)
            {
                suitePrice *= 0.85;
            }

            double finalStudioPrice = nights * studioPrice;
            double finalDoublePrice = nights * doublePrice;
            double finalSuitePrice = nights * suitePrice;

            if((month == "September" || month == "October") && nights > 7)
            {
                finalStudioPrice -= studioPrice;
            }

            Console.WriteLine("Studio: {0:F2} lv.", finalStudioPrice);
            Console.WriteLine("Double: {0:F2} lv.", finalDoublePrice);
            Console.WriteLine("Suite: {0:F2} lv.", finalSuitePrice);
        }
    }
}
