using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int symbol = input[0];//convert ot UniCode int
        if (symbol >=48 && symbol<=57)// from 0 to 9 in Unicode
            Console.WriteLine("digit");
        else if (symbol == 97 || symbol == 101 || symbol == 105 || symbol == 111 || symbol == 117)//a,e,i,o,u
            Console.WriteLine("vowel");
        else
            Console.WriteLine("other");
    }
}
        /*char ch = char.Parse(Console.ReadLine());
        if (ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch == 'u')
        {
            Console.WriteLine("vowel");
        }
        else if (ch=='1' || ch == '2' || ch == '3' || ch == '4' || ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9'|| ch=='0')
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }*/
