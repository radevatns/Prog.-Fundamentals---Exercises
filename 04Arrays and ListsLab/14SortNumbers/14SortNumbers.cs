using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        List<double> inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        inputList.Sort();
        Console.WriteLine(string.Join(" <= ",inputList));
        }
    }