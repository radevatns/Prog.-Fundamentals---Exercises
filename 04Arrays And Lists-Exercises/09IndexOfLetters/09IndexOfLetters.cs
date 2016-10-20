using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();
            var inputLetter = Console.ReadLine().ToLower().ToArray();
            for (int i = 0; i < inputLetter.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (inputLetter[i] == alphabet[j])
                    {
                        Console.WriteLine("{0} -> {1}", inputLetter[i], j);
                    }
                }
            }
        }
    }
}
