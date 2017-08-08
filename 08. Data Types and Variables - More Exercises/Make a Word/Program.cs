using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
