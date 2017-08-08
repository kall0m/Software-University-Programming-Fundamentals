using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<string> command = Console.ReadLine().Split(' ').ToList();

            while(command[0] != "Odd" && command[0] != "Even")
            {
                long element = long.Parse(command[1]);
                int position = 0;

                try
                {
                    position = int.Parse(command[2]);
                }
                catch
                {

                }

                switch (command[0])
                {
                    case "Delete": DeleteAnElementInList(nums, element); break;
                    case "Insert": InsertAnElementAtPositionInList(nums, element, position); break;
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            if(command[0] == "Odd")
            {
                PrintOddNumsInList(nums);
            }
            else if(command[0] == "Even")
            {
                PrintEvenNumsInList(nums);
            }
        }

        static void PrintEvenNumsInList(List<long> nums)
        {
            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static void PrintOddNumsInList(List<long> nums)
        {
            foreach (var num in nums)
            {
                if(num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

        static List<long> DeleteAnElementInList(List<long> nums, long element)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] == element)
                {
                    nums.Remove(nums[i]);
                    i--;
                }
            }

            return nums;
        }

        static List<long> InsertAnElementAtPositionInList(List<long> nums, long element, int position)
        {
            nums.Insert(position, element);

            return nums;
        }
    }
}
