using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var textToCharArray = text.ToCharArray();

            Array.Reverse(textToCharArray);

            text = new string(textToCharArray);

            Console.WriteLine(text);
        }
    }
}
