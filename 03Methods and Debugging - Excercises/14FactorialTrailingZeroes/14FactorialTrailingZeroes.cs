using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= inputNum; i++)
            {
                result *= i;
            }
            int count = 0;
            BigInteger tempResult = 0;

            while (result%10 == 0)
            {
                result = result / 10;
                count++;

            }
            Console.WriteLine(count);
                
                

            
        }
    }
}
