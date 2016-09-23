using System;

    class Program
    {
        static void Main()
        {
        var numbers = int.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < numbers; i++)
            {
                decimal customNum  = decimal.Parse(Console.ReadLine());
                sum += customNum;
            }  
        Console.WriteLine(sum);
        }
    }