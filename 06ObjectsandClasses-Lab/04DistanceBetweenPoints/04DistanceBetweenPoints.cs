using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)

        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalcDistance(p1, p2);
            Console.WriteLine("{0:f3}",distance);
        }

        private static double CalcDistance(Point p1, Point p2)// method for calculate distance by Pythagorean theorem
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
        }

        private static Point ReadPoint()// method for reading input parameter
        {
            int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
