using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var inputNum = Console.ReadLine().Split('|').ToList();
        inputNum.Reverse();
        var finalList = new List<string>();
            foreach (var item in inputNum)
            {
            List<string> list = item.Split(' ').ToList();//every item split by space
                foreach (var oneNum in list)
                {
                    
                finalList.Add(oneNum);
                finalList.RemoveAll(space => space == "");//!!! remove empty space!
                }
            }
        Console.WriteLine(string.Join(" ", finalList));
        }
    }