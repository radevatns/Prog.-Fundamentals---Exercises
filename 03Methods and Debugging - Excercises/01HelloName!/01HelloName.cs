using System;

    class Program
    {
        static void Main(string[] args)
    {
        string inputName = Console.ReadLine();

        nameof(inputName);

    }


    private static void nameof(string inputName)
    {
        Console.WriteLine("Hello, {0}!", inputName);
    }
}
