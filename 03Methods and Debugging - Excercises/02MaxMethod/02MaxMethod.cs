using System;
using System.Collections.Generic;
using System.Linq;


class Program
    {
    static void Main()
    {
        int numFirst = int.Parse(Console.ReadLine());
        int numSec = int.Parse(Console.ReadLine());
        GetMaxFirst(numFirst, numSec);//first method
        int middleResult = GetMaxFirst(numFirst, numSec);
        //Console.WriteLine("middleResult is: " + middleResult);

        int numThrird = int.Parse(Console.ReadLine());
        GetMaxSec(middleResult, numThrird);//sec method
        Console.WriteLine(GetMaxSec(middleResult, numThrird));
    }

    private static int GetMaxSec(int finalResult, int numThrird)
    {
        if (finalResult > numThrird)
        {
            return (finalResult);
        }
        else
        {
            return (numThrird);
        }
    }
    private static int GetMaxFirst(int numFirst, int numSec)
    {
        if (numFirst>numSec)
        {
            return (numFirst);
        }
        else
        {
            return (numSec);
        }
    }
}
