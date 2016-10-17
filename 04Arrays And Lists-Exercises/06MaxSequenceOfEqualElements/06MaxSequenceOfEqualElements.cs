using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 1;
            int num = 1;
            int tempCnt = 1;
            for (int i = 1; i <inputNums.Length; i++)
            {
                if (inputNums[i-1] == inputNums[i])
                {
                    tempCnt++;
                    if (tempCnt > cnt)
                    {
                        num = inputNums[i];
                    }
                }
                else
                {
                    if (tempCnt> cnt)
                    {
                        cnt = tempCnt;
                        
                    }
                    tempCnt = 1;
                }
            }
            if (cnt == 1)
            {
                cnt = tempCnt;
            }
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
