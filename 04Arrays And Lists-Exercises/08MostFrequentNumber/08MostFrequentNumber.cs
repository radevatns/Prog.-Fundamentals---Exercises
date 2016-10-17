using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            var inputNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            var mostFrequent = inputNum.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(i => i.Key).First();
            Console.WriteLine(mostFrequent);


        }
    }
}
