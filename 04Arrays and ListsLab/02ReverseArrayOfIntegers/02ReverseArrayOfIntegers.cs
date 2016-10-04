using System;

class Program
{
    static void Main()
    {
    var numberOfElement = int.Parse(Console.ReadLine());
    int[] arr = new int[numberOfElement];
        for (int i = 0; i < arr.Length; i++)
        {
            var n = int.Parse(Console.ReadLine());
            arr[i] = n;
        }
        for (int i = arr.Length-1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}