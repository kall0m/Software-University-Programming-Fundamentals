using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = ReadDate();
            DateTime endDate = ReadDate();

            var officialHolidays = new DateTime[12];

            officialHolidays[0] = new DateTime(4, 1, 1);
            officialHolidays[1] = new DateTime(4, 3, 3);
            officialHolidays[2] = new DateTime(4, 5, 1);
            officialHolidays[3] = new DateTime(4, 5, 6);
            officialHolidays[4] = new DateTime(4, 5, 24);
            officialHolidays[5] = new DateTime(4, 9, 6);
            officialHolidays[6] = new DateTime(4, 9, 22);
            officialHolidays[7] = new DateTime(4, 11, 1);
            officialHolidays[8] = new DateTime(4, 12, 24);
            officialHolidays[9] = new DateTime(4, 12, 25);
            officialHolidays[10] = new DateTime(4, 12, 26);

            int workingDaysCounter = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if(i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !officialHolidays.Any(h => h.Day == i.Day && h.Month == i.Month))
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }

        private static DateTime ReadDate()
        {
            return DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}
