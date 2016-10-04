using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        
        while (arr.Length>1)
        {
            int[] condensed = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                condensed[i] = arr[i] + arr[i + 1];
            }
            arr = condensed;
        }
        Console.WriteLine(arr[0]);
    }
}