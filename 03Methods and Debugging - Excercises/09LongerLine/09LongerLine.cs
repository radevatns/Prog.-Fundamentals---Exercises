using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = GetDitanceBetweenTwoPoints(x1, y1, x2, y2);
            double secondLineLength = GetDitanceBetweenTwoPoints(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                printLine(x1, y1, x2, y2);//Console.WriteLine("({0}, {1})({2, {3})");
            }
            else
            {
                printLine(x3, y3, x4, y4);
            }
        }

        private static void printLine(double x1, double y1, double x2, double y2)
        {
            double c1 = Math.Abs(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));//c^2 = a^2 +b^2 
            double c2 = Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));// no work with or without Math.Abs
            if (c2 < c1)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {x1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        private static double GetDitanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = (Math.Sqrt(Math.Pow((x2- x1), 2) + Math.Pow((y2 - y1), 2)));
            return distance;
        }
    }
}
