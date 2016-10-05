using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
        static void Main()
    {
        List<double> inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        for (int i = 1; i < inputList.Count; i++)
        {
            if (inputList[i] == inputList[i-1])
            {
                inputList[i] = inputList[i] * 2;
                inputList.Remove(inputList[i - 1]);
                i = 0;
            }
        }
        Console.WriteLine(string.Join(" ",inputList));
    }
    }
