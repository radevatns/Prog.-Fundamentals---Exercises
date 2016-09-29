using System;

    class Program
    {
        static void Main(string[] args)
        {
        double wigth = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double areaOfTriangle = GetAreaTriangle(wigth,h);
        GetAreaTriangle(wigth, h);

        Console.WriteLine(areaOfTriangle);
        }

    static double GetAreaTriangle(double wigth, double hight)
    {
        return (wigth * hight) / 2;
    }
}