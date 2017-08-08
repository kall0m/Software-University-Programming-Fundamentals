using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "print")
            {
                string[] attributes = command.Split(' ');

                /*for (int i = 1; i < command.Count; i++)
                {
                    attributes.Add(int.Parse(command[i]));
                }*/

                switch (attributes[0])
                {
                    case "add": /*AddElemInList(attributes, nums);*/ nums.Insert(int.Parse(attributes[1]), int.Parse(attributes[2])); break;
                    case "addMany": AddManyElemsInList(attributes, nums); break;
                    case "contains": /*FindElemInList(attributes, nums);*/ Console.WriteLine(nums.IndexOf(int.Parse(attributes[1]))); break;
                    case "remove": /*RemoveElemInList(attributes, nums);*/ nums.RemoveAt(int.Parse(attributes[1])); break;
                    case "shift": ShiftElemsInList(int.Parse(attributes[1]), nums); break;
                    case "sumPairs": SumByPairs(nums); break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        static void SumByPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
        }

        static void ShiftElemsInList(int positions, List<int> nums)
        {
            for (int i = 0; i < positions; i++)
            {
                int start = nums[0];

                for (int j = 0; j < nums.Count - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }

                nums[nums.Count - 1] = start;
            }
        }

        /*static void RemoveElemInList(List<int> index, List<int> nums)
        {
            nums.RemoveAt(index[0]);
        }*/

        /*static void FindElemInList(List<int> find, List<int> nums)
        {
            int element = find[0];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == element)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }*/

        static void AddManyElemsInList(string[] indexAndElems, List<int> nums)
        {
            int index = int.Parse(indexAndElems[1]);

            var elementsToAdd = indexAndElems.Skip(2).Select(int.Parse).ToList();
            elementsToAdd.Reverse();

            for (int i = 0; i < elementsToAdd.Count; i++)
            {
                nums.Insert(index, elementsToAdd[i]);
            }
        }

        /*static void AddElemInList(List<int> indexAndElem, List<int> nums)
        {
            int index = indexAndElem[0];
            int element = indexAndElem[1];

            nums.Insert(index, element);
        }*/
    }
}
