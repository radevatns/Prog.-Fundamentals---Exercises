using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        string[] numbersAsString = Console.ReadLine().ToLower().Split();
        Dictionary<string, int> wordByCount = new Dictionary<string, int>();
        for (int i = 0; i < numbersAsString.Length; i++)
        {
            if (wordByCount.ContainsKey(numbersAsString[i]))
            {
                wordByCount[numbersAsString[i]]++;
            }
            else
	        {
                wordByCount[numbersAsString[i]] = 1;
            }
        }
        List<string> words = new List<string>();
        foreach(string word in wordByCount.Keys)
        {
            if (wordByCount[word] %2 ==1)
            {
                words.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ", words));
        
        //string input = Console.ReadLine().ToLower();
        //string[] words = input.Split(' ');
        //var countsDict = new Dictionary<string, int>();
        //foreach (var oneWord in words)
        //{ 
        //    if (countsDict.ContainsKey(oneWord))
        //    {
        //        countsDict[oneWord]++;
        //    }
        //    else
        //    {
        //        countsDict[oneWord] = 1;
        //    }
        //}
        //var results = new List<string>();

    }
}