using System;

    class Program
    {
        static void Main()
        {
        var n = decimal.Parse(Console.ReadLine());//count of people 
        var p = decimal.Parse(Console.ReadLine());// capacity of elevator
        var cources = Math.Ceiling(n / p);
        Console.WriteLine(cources);
        }
    }