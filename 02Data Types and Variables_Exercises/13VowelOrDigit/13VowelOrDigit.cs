using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int symbol = input[0];//convert ot UniCode int
        if (symbol >=48 && symbol<=57)
            Console.WriteLine("digit");
        else if (symbol == 97 || symbol == 101 || symbol == 105 || symbol == 111 || symbol == 117)//a,e,i,o,u
            Console.WriteLine("vowel");
        else
            Console.WriteLine("other");
    }
}
