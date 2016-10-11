using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _03BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long inputNum = long.Parse(Console.ReadLine());
            BigInteger finalResult = 1;//added from right click on preference and add reference - using system.numerics
            for (int i = 1; i <=inputNum; i++)
            {
                finalResult *= i;
                
            }
            Console.WriteLine(finalResult);
        }
    }
}
