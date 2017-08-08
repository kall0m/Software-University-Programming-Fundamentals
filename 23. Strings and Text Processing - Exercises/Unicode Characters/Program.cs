using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            foreach (var symbol in text)
            {
                Console.Write(string.Format("\\u{0:x4}", Convert.ToUInt16(symbol)));
            }
        }
    }
}
