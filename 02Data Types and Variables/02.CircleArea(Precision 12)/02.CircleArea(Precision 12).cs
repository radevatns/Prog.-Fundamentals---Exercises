using System;

    class Program
    {
        static void Main()
        {
        var radius = double.Parse(Console.ReadLine());
        var area = Math.PI * (radius * radius);
        Console.WriteLine("{0:f12}", area);
        }
    }

