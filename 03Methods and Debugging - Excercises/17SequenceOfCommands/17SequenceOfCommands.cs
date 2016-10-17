﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';
        static void Main()
        {

            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(' ');

            while (!command.Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();
                int[] args = new int[2];

                if (command.Equals("add") || command.Equals("subtract") || command.Equals("multiply"))
                {
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);

                    //PerformAction(array, command, args);
                }

                PerformAction(array, command[0], args);

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine().Split(ArgumentsDelimiter);
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos-1] *= value;
                    break;
                case "add":
                    array[pos-1] += value;
                    break;
                case "subtract":
                    array[pos-1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long tempValue = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = tempValue;
        }
        private static void ArrayShiftLeft(long[] array)
        {
            long tempValue = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = tempValue;
        }
        private static void PrintArray(long[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
    
}