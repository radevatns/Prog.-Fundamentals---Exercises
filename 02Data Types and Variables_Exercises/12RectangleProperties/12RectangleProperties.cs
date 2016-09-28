using System;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;
                
        double diagonal = Math.Sqrt(Math.Pow (width, 2) + Math.Pow(height,2));

        Console.WriteLine("{0}\n{1}\n{2}",perimeter, area, diagonal);
    }
}  