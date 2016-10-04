using System;
using System.Collections.Generic;
using System.Linq;

    class Program
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        int[] firstArr = new int[firstInput.Length];
        for (int i = 0; i < firstInput.Length; i++)
        {
            firstArr[i] = int.Parse(firstInput[i]);
        }
        //Console.WriteLine(string.Join(" ", firstArr));

        string[] secInput = Console.ReadLine().Split();
        int[] secArr = new int[secInput.Length];

        for (int i = 0; i < secInput.Length; i++)
        {
            secArr[i] = int.Parse(secInput[i]);
        }
        //Console.WriteLine(string.Join(" ", secArr));

        int[] sumArr = new int[Math.Max(firstArr.Length, secArr.Length)];


            for (int sum = 0; sum < sumArr.Length; sum++)
            {
            sumArr[sum] = firstArr[sum % firstArr.Length] + secArr[sum % secArr.Length];
            }
        Console.WriteLine(string.Join(" ",sumArr));
       
    }
}