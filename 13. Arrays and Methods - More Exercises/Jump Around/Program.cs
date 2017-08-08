using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            int i = 0;

            while(i >= 0)
            {
                if (i < array.Length)
                {
                    if (i + array[i] < array.Length)
                    {
                        sum += array[i];
                        i += array[i];
                    }
                    else
                    {
                        sum += array[i];
                        i -= array[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
