using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i <inputList.Count ; i++)
        {
            if (inputList [i] <0)
            {
                inputList.Remove(inputList[i]);
                i--;
            }
        }
        if (inputList.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            inputList.Reverse();
            Console.Write(string.Join(" ", inputList));
        }
    }
}