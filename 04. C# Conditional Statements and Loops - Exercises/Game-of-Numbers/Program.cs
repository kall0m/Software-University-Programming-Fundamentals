using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool check = false;
            int lastN = 0;
            int lastM = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        lastN = i;
                        lastM = j;
                        check = true;
                    }
                }
            }

            if(check)
            {
                Console.WriteLine($"Number found! {lastN} + {lastM} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
