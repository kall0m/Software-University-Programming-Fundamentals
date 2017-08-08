using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureX
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, j = 2; i < n / 2; i++, j+=2)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', i), new string(' ', n - j));
            }
            Console.WriteLine("{0}x{0}", new string(' ', (n - 1) / 2));
            for (int i = 0, j = 1; i < n / 2; i++, j += 2)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ', (n - 3) / 2 - i), new string(' ', j));
            }
        }
    }
}
