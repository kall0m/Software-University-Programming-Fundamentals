using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if(bomb[0] == nums[i])
                {
                    for (int j = i - 1; j >= i - bomb[1]; j--)
                    {
                        try
                        {
                            nums[j] = 0;
                        }
                        catch
                        {
                            break;
                        }
                    }

                    for (int j = i + 1; j <= i + bomb[1]; j++)
                    {
                        try
                        {
                            nums[j] = 0;
                        }
                        catch
                        {
                            break;
                        }
                    }

                    nums[i] = 0;
                }
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
