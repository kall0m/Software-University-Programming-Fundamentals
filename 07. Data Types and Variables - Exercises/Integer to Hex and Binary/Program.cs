using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numToHexa = Convert.ToString(num, 16).ToUpper();
            string numToBinary = Convert.ToString(num, 2);

            Console.WriteLine(numToHexa);
            Console.WriteLine(numToBinary);
        }
    }
}
