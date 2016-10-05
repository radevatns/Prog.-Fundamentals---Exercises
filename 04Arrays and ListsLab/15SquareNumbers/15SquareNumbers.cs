using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> sqrtList = new List<int>();
        foreach (var numbers in inputList)
        {
            if (Math.Sqrt(numbers) == (int)Math.Sqrt(numbers) )
            {
                sqrtList.Add(numbers);
            }
        }
        sqrtList.Sort();
        sqrtList.Reverse();
        Console.WriteLine(string.Join(" ",sqrtList));
    }
    }