using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string integer = Console.ReadLine();

            try
            {
                long num = long.Parse(integer);
                Console.WriteLine($"{integer} can fit in:");
            }
            catch
            {
                Console.WriteLine($"{integer} can't fit in any type");
                return;
            }

            try
            {
                sbyte num = sbyte.Parse(integer);
                Console.WriteLine("* sbyte");
            }
            catch
            {

            }

            try
            {
                byte num = byte.Parse(integer);
                Console.WriteLine("* byte");
            }
            catch
            {

            }

            try
            {
                short num = short.Parse(integer);
                Console.WriteLine("* short");
            }
            catch
            {

            }

            try
            {
                ushort num = ushort.Parse(integer);
                Console.WriteLine("* ushort");
            }
            catch
            {

            }

            try
            {
                int num = int.Parse(integer);
                Console.WriteLine("* int");
            }
            catch
            {

            }

            try
            {
                uint num = uint.Parse(integer);
                Console.WriteLine("* uint");
            }
            catch
            {

            }

            try
            {
                long num = long.Parse(integer);
                Console.WriteLine("* long");
            }
            catch
            {
                
            }
        }
    }
}
