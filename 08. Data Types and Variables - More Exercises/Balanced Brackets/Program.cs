using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int balanced = 0;
            string oldBracket = "";

            for (int i = 0; i < n; i++)
            {
                string randomString = Console.ReadLine();

                if(randomString == oldBracket)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

                if(randomString == "(")
                {
                    oldBracket = randomString;
                    balanced++;
                }
                else if(randomString == ")")
                {
                    oldBracket = randomString;
                    balanced--;
                }
            }

            if(balanced == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
