using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            /*int value;
            while (int.TryParse(Console.ReadLine(), out value))
            {
                count++;
            }
            Console.WriteLine(count);*/
            try
            {
                while (true)
                {
                    int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch(Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}
