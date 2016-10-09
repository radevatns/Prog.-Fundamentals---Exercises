using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NumbersInReversedOrder
{
    class Program
    {
        static void Main()

        {
            var inputNum = Console.ReadLine();
            //GetNumbersInReversedOrder(inputNum);

            var finalResult = GetNumbersInReversedOrder(inputNum);
            Console.WriteLine(finalResult);
        }

        private static string GetNumbersInReversedOrder(string inputNum)
        {
            var reverseNum = "";
            for (int i = inputNum.Length - 1; i >=0 ; i--)
            {
                reverseNum += inputNum[i];
            }
            return reverseNum;
        }

        }
    }
    

/* fint from dotnetperls

    {
            string inputNum = Console.ReadLine();
            Console.WriteLine(StringHelper.ReverseString(inputNum));
            
        }
        static class StringHelper
        {
            public static string ReverseString(string s)
            {
                char[] inputNumInCharArr = s.ToCharArray();
                Array.Reverse(inputNumInCharArr);
                return new string(inputNumInCharArr);
            }
        }

*/
