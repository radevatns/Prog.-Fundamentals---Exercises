using System;

    class Program
    {
        static void Main(string[] args)
        {
        var n = int.Parse(Console.ReadLine());
        printTriangle(n);
        }
    private static void printTriangle(int n)
     {
        upperPart(1, n);
        bottomPart(1, n);
     }
    private static void upperPart(int a, int n)
    {
        for (int i = a; i <= n; i++)
        {
            for (int k = 1; k < i; k++)
                Console.Write(k + " ");
            Console.WriteLine(i);
        }
    }
    private static void bottomPart(int v, int n)
    {
        for (int i = n-1; i >= 1; i--)
        {
            for (int k = 1; k < i; k++)
                Console.Write(k + " ");
            Console.WriteLine(i);
        }
    }
}