using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhonebookUpgrade
{
    class Program
    {
        static void Main()
        {
            bool isEnd = true;
            var phoneDict = new SortedDictionary<string, string>();
            while (isEnd == true)
            {
                string input = Console.ReadLine();
                string[] inputList = input.Split(' ');

                if (inputList[0] == "A")
                    //phoneDict.Add(inputList[1], inputList[2]);// this is not work while we have same key
                    phoneDict[inputList[1]] = inputList[2];
                else if (inputList[0] == "S")
                {
                    if (phoneDict.ContainsKey(inputList[1]))
                        Console.WriteLine("{0} -> {1}", inputList[1], phoneDict[inputList[1]]);
                    else
                        Console.WriteLine($"Contact {inputList[1]} does not exist.");
                }
                else if ((string)inputList[0] == "ListAll")
                {
                   //phoneDict =  phoneDict.OrderBy(x => x.Key);


                    foreach (KeyValuePair<string, string> pair in phoneDict)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }

                else if ((string)inputList[0] == "END")
                    isEnd = false;
            }
        }
    }
}
