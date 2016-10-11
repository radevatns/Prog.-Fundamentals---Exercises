using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= inputNum; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
