﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int n1 = a; n1 <= b; n1++)
            {
                if(b - a < 5)
                {
                    Console.WriteLine("No");
                    break;
                }
                for (int n2 = a; n2 <= b; n2++)
                {
                    for (int n3 = a; n3 <= b; n3++)
                    {
                        for (int n4 = a; n4 <= b; n4++)
                        {
                            for (int n5 = a; n5 <= b; n5++)
                            {
                                if(a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", n1, n2, n3, n4, n5);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
