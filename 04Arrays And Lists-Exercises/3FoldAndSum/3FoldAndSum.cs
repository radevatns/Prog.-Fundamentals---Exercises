using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int[] upperRow = new int[inputNums.Length / 2];
            for (int i = 0; i < inputNums.Length/4; i++)
            {
                upperRow[(upperRow.Length-1)/2 - i] = inputNums[i];
                upperRow[upperRow.Length / 2 + i] = inputNums[inputNums.Length - 1 - i];
            }
            int[] resultArray = new int[upperRow.Length];

            for (int i = 0; i < upperRow.Length; i++)
            {
                resultArray[i] = upperRow[i] + inputNums[inputNums.Length/4+i];
            }
            Console.WriteLine(string.Join(" ", resultArray));
         
        }
    }
}
