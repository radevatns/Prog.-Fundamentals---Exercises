using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var numOfNumbers = int.Parse(Console.ReadLine());
        List<int> inputList = new List<int>();
        for (int i = 0; i < numOfNumbers; i++)
        {
            int oneNum = int.Parse(Console.ReadLine());
            inputList.Add(oneNum);
        }
        Console.WriteLine($"Sum = {inputList.Sum()}");
        Console.WriteLine($"Min = {inputList.Min()}");
        Console.WriteLine($"Max = {inputList.Max()}");
        Console.WriteLine($"Average = {inputList.Average()}");
    }
    }
