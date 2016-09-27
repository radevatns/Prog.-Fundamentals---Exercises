using System;

class Program
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        sbyte age = sbyte.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        long numID = long.Parse(Console.ReadLine());
        int uniqueNum = int.Parse(Console.ReadLine());
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firstName, lastName, age, gender, numID, uniqueNum);
    }
}