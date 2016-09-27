using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}",a);
        Console.WriteLine("b = {0}",b);
        int tempValue = b;
        b = a;
        a = tempValue;
        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}