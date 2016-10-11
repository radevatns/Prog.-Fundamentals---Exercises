using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {

            Point[] points = ReadPoint();
            //int[] firstCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] secondCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            private static Point ReadPoint()// method for reading input parameter
        {
            int[] pointInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        };




            //bool Intersect(Circle c1, Circle c2);


        }
    }
}
