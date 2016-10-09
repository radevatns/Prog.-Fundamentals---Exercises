using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var inputNum = long.Parse(Console.ReadLine());
        isPrime(inputNum);
        var result = isPrime(inputNum);
        Console.WriteLine(result);
         
        }

        private static object isPrime(long inputNum)
    {
        bool isPrime = true;
        if (inputNum <=1)
        {
            isPrime = false;
        }
        for (int k = 2; k <= Math.Sqrt(inputNum); k++)
        {
            if (inputNum % k == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;

        /*for (int i = 2; i <= inputNum; i++)
        {
            
            for (int k = 2; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }*/
        //return isPrime;
    }
}

  
/*int inputNum = int.Parse(Console.ReadLine());
        for (int i = 2; i <= inputNum; i++)
        {
            bool isTrue = true;
            for (int k = 2; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    isTrue = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isTrue}");
        }
*/
