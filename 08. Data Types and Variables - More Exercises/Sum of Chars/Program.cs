using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
