using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01CountWorkDays
{
    class Program
    {
        static void Main()
        {
            string inputStartData = Console.ReadLine();
            string inputEndData = Console.ReadLine();
            DateTime startData = DateTime.ParseExact(inputStartData, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endData = DateTime.ParseExact(inputEndData, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            
            DateTime[] holidays = new DateTime[11];
            holidays[0] = new DateTime(4, 01, 01);
            holidays[1] = new DateTime(4, 03, 03);
            holidays[2] = new DateTime(4, 05, 01);
            holidays[3] = new DateTime(4, 05, 06);
            holidays[4] = new DateTime(4, 05, 24);
            holidays[5] = new DateTime(4, 09, 06);
            holidays[6] = new DateTime(4, 09, 22);
            holidays[7] = new DateTime(4, 11, 01);
            holidays[8] = new DateTime(4, 12, 24);
            holidays[9] = new DateTime(4, 12, 25);
            holidays[10] = new DateTime(4, 12, 26);

            int cntWorkDay = 0;
            for (var data= startData; data <= endData; data=data.AddDays(1))
            {
                if (data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday && !holidays.Any(d => d.Day == data.Day && d.Month == data.Month))
                //if (data.DayOfWeek != DayOfWeek.Saturday || data.DayOfWeek != DayOfWeek.Sunday || holidays.Any(d => d.Day == data.Day && d.Month == data.Month))
                {
                    cntWorkDay++;
                }
                
            }
            Console.WriteLine(cntWorkDay);
        }
    }
}
