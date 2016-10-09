using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
        var inputNum = long.Parse(Console.ReadLine());
        var finalResult = GetFibNumber(inputNum);
        Console.WriteLine(finalResult);

    }

    private static long GetFibNumber(long inputNum)
    {
        long firstNum = 0;    //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 
        long secNum = 1;
        long result = 0;                    
        for (long i = 0; i < inputNum; i++)
        {                                   
            result = firstNum + secNum;             
            firstNum = secNum;
            secNum = result;
        }
        if (inputNum == 0)
        {
            result = 1;
        }
        return result;
    }
}