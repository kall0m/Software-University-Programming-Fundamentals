using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char notPrint = char.Parse(Console.ReadLine());

            for (char i = begin; i <= end; i++)
            {
                for (char j = begin; j <= end; j++)
                {
                    for (char k = begin; k <= end; k++)
                    {
                        if(!(i == notPrint || j == notPrint || k == notPrint))
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
