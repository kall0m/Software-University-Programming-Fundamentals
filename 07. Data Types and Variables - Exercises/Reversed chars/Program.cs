using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = "";
            for (int i = 0; i < 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                reverse += letter;
            }
            int len = reverse.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write(reverse[i]);
            }
        }
    }
}
