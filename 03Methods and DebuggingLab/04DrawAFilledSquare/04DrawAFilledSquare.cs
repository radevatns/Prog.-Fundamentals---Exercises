using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        firstLastLine(n);
        for (int i = 0; i < n-2; i++)
        {
            middleLine(n);
        }
        firstLastLine(n);
    }
    
    private static void firstLastLine(int n)
    {
        Console.WriteLine(new string('-', 2*n));
    }
    private static void middleLine(int n)
    {
        Console.Write("-");
        for (int i = 0; i < ((n)-2)+1 ; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}