using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool notFound = true;

            for (int i = 0; i < inputList.Count; i++)
            {
                long leftSum = 0;
                long rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += inputList[j];
                }
                for (int j = i + 1; j < inputList.Count; j++)
                {
                    rightSum += inputList[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    notFound = false;
                }
            }
            if (notFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
