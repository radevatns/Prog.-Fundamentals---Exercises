using System;

class Program
{
    static void Main()
    {
        string strFirstWord = "Hello";
        string strSecWord = "World";
        object allSentences = strFirstWord + ' ' + strSecWord;
        string strAllSentences = (string)allSentences;

        Console.WriteLine(strAllSentences);
    }
}