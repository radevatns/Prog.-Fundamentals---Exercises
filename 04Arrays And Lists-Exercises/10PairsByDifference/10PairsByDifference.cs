using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int cntPair = 0;
            for (int i = 0; i < inputNum.Length; i++)
            {
                for (int j = i+1; j < inputNum.Length; j++)
                {
                    if (inputNum[i] == (inputNum[j]+diff) || inputNum[i] == (inputNum[j] - diff))
                    {
                        cntPair++;
                    }
                }
            }
            Console.WriteLine(cntPair);
        }
    }
}
