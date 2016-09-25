using System;

    class Program
    {
        static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        var years = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello,{0} {1}. You are {2} years old",firstName,secondName,years);
    }
}
