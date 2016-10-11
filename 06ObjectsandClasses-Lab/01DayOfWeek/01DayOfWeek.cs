using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
           string inputData = Console.ReadLine();
            DateTime finalDate = DateTime.ParseExact(inputData, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(finalDate.DayOfWeek);                         
        }
    }
}
