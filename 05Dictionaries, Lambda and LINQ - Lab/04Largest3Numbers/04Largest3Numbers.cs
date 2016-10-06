using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> inputList = Console.ReadLine().Split().Select(double.Parse).ToList();
            var sortedNums = inputList.OrderByDescending(x => x);
            var largest3Num = sortedNums.Take(3);
            //inputList.Sort(); // or this
            //inputList.Reverse();
            //var largest3Num = inputList.Take(3);

            Console.WriteLine(string.Join(" ", largest3Num));
        }
    }
}
