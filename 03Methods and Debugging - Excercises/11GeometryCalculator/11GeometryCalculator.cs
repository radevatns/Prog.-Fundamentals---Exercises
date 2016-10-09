using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            double result=0;
            if (typeOfFigure.Equals("triangle"))//•	Triangle - side and height 	!Square - side•	Rectangle - width and height •	Circle - radius
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());
                result = (firstParameter * secondParameter) / 2;
            }
            else if (typeOfFigure.Equals("square"))
            {
                double firstParameter = double.Parse(Console.ReadLine());
                result = firstParameter * firstParameter;
            }
            else if (typeOfFigure.Equals("rectangle"))
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());
                result = (firstParameter * secondParameter);
            }
            else if (typeOfFigure.Equals("circle"))
            {
                double firstParameter = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(firstParameter, 2);
            }
            Console.WriteLine("{0:f2}",result);
            
        }
    }
}
