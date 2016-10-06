using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        bool isEnd = true;
        var phoneDict = new Dictionary<string, string>();
        while (isEnd == true)
        {
            string input = Console.ReadLine();
            string[] inputList = input.Split(' ');

            if (inputList[0] == "A")
                //phoneDict.Add(inputList[1], inputList[2]);
                phoneDict[inputList[1]] = inputList[2];// !!!! if key is the same override the key new-> old

            else if (inputList[0] == "S")
            {
                if (phoneDict.ContainsKey(inputList[1]))
                    Console.WriteLine("{0} -> {1}", inputList[1], phoneDict[inputList[1]]);
                else
                    Console.WriteLine($"Contact {inputList[1]} does not exist.");
            }

            else if ((string)inputList[0] == "END")
                isEnd = false;
        }
    }
}

//string[] inputList = Console.ReadLine().Split(' ').ToArray();
//Dictionary<string, int> phoneDict = new Dictionary<string, int>();
//var counts = new Dictionary<string, int>;