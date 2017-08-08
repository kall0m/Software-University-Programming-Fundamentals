using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int sequences = 0;
            string nucleicAcidSequence = "ACGT";

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        if(i + j + k >= sum)
                        {
                            Console.Write($"O{nucleicAcidSequence[i - 1]}{nucleicAcidSequence[j - 1]}{nucleicAcidSequence[k - 1]}O ");
                        }
                        else
                        {
                            Console.Write($"X{nucleicAcidSequence[i - 1]}{nucleicAcidSequence[j - 1]}{nucleicAcidSequence[k - 1]}X ");
                        }
                        
                        sequences++;

                        if (sequences % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
