﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_of_Commands
{
    class Program
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] stringParams = command.Split(' ');
                int[] args = new int[2];

                if (stringParams[0].Equals("add") ||
                    stringParams[0].Equals("subtract") ||
                    stringParams[0].Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, stringParams[0], args);
                }
                else
                {
                    PerformAction(array, stringParams[0], args);
                }

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        static void ArrayShiftRight(long[] array)
        {
            long lastElement = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

        static void ArrayShiftLeft(long[] array)
        {
            long firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;

        }

        static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
