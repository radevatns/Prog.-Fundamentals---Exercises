using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequenceIncreasingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int tempCnt = 0;
            int cnt = 0;
            int startSequence = 0;
            int tempStartSequence = 0;
            for (int i = 1; i < inputArr.Length; i++)
            {
                if (inputArr[i - 1] == (inputArr[i]-1))
                {
                    tempCnt++;
                    if (tempStartSequence ==0)
                    {
                        tempStartSequence = i;
                    }   
                }
                else
                {
                    if (tempCnt > cnt)
                    {
                        cnt = tempCnt;
                        startSequence = tempStartSequence;
                    }
                    tempCnt = 0;
                    tempStartSequence = 0;
                }
            }
            if (tempCnt > cnt)
            {
                cnt = tempCnt;
                startSequence = tempStartSequence;
            }
            if (startSequence <= 0 )
            {
                Console.WriteLine("0");
            }
            else
            { 
                for (int i = startSequence-1; i <= ((startSequence - 1)+cnt); i++)
                {
                    Console.Write(inputArr[i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
