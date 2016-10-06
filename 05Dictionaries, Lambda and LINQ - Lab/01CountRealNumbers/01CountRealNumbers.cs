using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); 
        var counts = new SortedDictionary<double, int>();
        // or SortedDictionary<double, int> counts = new SortedDictionary<double, int>;
        foreach (var num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        foreach (double num in counts.Keys)
        {
            Console.WriteLine($"{num} -> {counts[num]}");
        }
        

        //Dictionary<string, int> inputDictionary = new Dictionary<string, int>();
        //foreach (var key in inputDictionary.Keys)
        //    {
        //        Console.WriteLine(key);
        //    }
        //foreach (var value in inputDictionary.Values)
        //    {
        //        Console.WriteLine(value);
        //    }

        }
    }