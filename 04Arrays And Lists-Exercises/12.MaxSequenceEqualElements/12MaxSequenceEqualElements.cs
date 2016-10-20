using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 1;
            int bestStart = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    start = i;
                    length++;
                }
                else
                {
                    if (length > bestLength)
                    {
                        bestLength = length;

                        bestStart = start;
                        start = 0;
                    }
                    length = 1;
                }

            }
            if (bestLength == 1 && length != 1)
            {
                bestLength = length;
                bestStart = start;
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(inputList[bestStart] + " ");
            }
        }
    }
}
