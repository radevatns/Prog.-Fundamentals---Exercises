using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var separators = ",;:.!()\"'/\\ [] ".ToArray();
        
        var inputText = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
        var lowerCase = new List<string>();
        var upperCase = new List<string>();
        var mixedCase = new List<string>();
        foreach (var word in inputText)
        {
            int cntLower = 0;
            int cntUpper = 0;
            foreach (var symbol in word)
            {
                if (char.IsLower(symbol))
                    cntLower++;
                if (char.IsUpper(symbol))
                    cntUpper++;
            }
            if (cntLower == word.Length)
                lowerCase.Add(word);
            else if (cntUpper == word.Length)
                upperCase.Add(word);
            else
                mixedCase.Add(word);
        }
        
        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
    }
    }