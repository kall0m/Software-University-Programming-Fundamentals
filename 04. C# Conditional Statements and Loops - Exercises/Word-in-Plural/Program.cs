using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1);
                noun = noun + "ies";
            }
            else if(noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun = noun + "es";
            }
            else
            {
                noun = noun + "s";
            }

            Console.WriteLine(noun);
        }
    }
}
