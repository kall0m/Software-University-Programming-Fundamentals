using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var indexOfFirstOccOfPattern = str.IndexOf(pattern);
                var indexOfLastOccOfPattern = str.LastIndexOf(pattern);

                if (indexOfFirstOccOfPattern + pattern.Length - 1 < indexOfLastOccOfPattern && pattern.Length > 0)
                {
                    str = str.Remove(indexOfLastOccOfPattern, pattern.Length);
                    str = str.Remove(indexOfFirstOccOfPattern, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }     

            Console.WriteLine(str);
        }
    }
}
