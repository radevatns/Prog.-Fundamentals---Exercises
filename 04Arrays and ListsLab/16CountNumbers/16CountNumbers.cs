using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();//if add this "OrderBy(x => x)" tne list was sorted
        inputList.Sort();
        var cnt = 1;
        var previousElement = inputList[0];
        for (int i = 1; i < inputList.Count; i++)
        {
            if (previousElement == inputList[i])
            {
                cnt++;
            }
            else
            {
                Console.WriteLine("{0} -> {1}",previousElement,cnt);
                previousElement = inputList[i];
                cnt = 1;
            }
        }
        Console.WriteLine("{0} -> {1}", previousElement, cnt);
    }
        
    }