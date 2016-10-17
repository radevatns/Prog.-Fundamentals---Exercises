using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());

            var sum = new int[inputNums.Length];

            //var result = SumOfElements(inputNums, sum, rotation);
           


            for (int i = 0; i < rotation; i++)
            {
                int lastElement = inputNums[inputNums.Length - 1];

                Array.Copy(inputNums,0, inputNums,1, inputNums.Length - 1);// 0 is sourceIndex Type: System.Int32 A 32 - bit integer that represents the index in the sourceArray at which copying begins.
                  // 1 is : destinationIndex Type: System.Int32 A 32 - bit integer that represents the index in the destinationArray at which storing begins.
                inputNums[0] = lastElement;

                for (int k = 0; k < inputNums.Length; k++)
                {
                    sum[k] += inputNums[k];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
         
    }
}
//int[] inputNum = Console.ReadLine().Split(' ').Select(int.Parse).ToinputNumsay();
//int [] 
//int NumOfRotate = int.Parse(Console.ReadLine());
//int tempLastDigit = inputNum[0];
//for (int i = 0; i < inputNum.Length-1; i++)
//{
//    inputNum[i] = inputNum[i + 1];
//}
//inputNum[inputNum.Length - 1] = tempLastDigit;


//for (int i = 0; i < inputNum.Length; i++)
//{
//    Console.Write(inputNum[i] + " ");
//}