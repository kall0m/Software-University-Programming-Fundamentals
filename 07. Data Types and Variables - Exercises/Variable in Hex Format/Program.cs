using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexaNum = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(hexaNum);
        }
    }
}
