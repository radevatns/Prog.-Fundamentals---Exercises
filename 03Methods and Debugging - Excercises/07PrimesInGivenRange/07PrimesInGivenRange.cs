using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var result= GetPrimesInGivenRange(startNum, endNum);
            Console.WriteLine(string.Join(", ",result));
        }

        private static List<int> GetPrimesInGivenRange(int startNum, int endNum)
        {
            var resultList = new List<int>();
           
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0  )
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (i == 0 || i == 1 || i == 2)
                    isPrime = false;
                if (isPrime)
                    resultList.Add(i);
            }
            return (resultList);
        }
    }
}
