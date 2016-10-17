using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            bool[] primesNum = new bool[inputNum + 1];
            for (int i = 1; i <= inputNum; i++)
            {
                primesNum[i] = true;
            }
            primesNum[1] = primesNum[0] = false;

            for (int i = 2; i <= inputNum; i++)
            {
                if (primesNum[i] == true)
                {
                    for (int k = 2; k * i <= inputNum; k++)//why k*i
                    {
                        primesNum[k * i] = false;
                    }
                }
            }
            for (int i = 0; i <= inputNum; i++)
            {
                if (primesNum[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
