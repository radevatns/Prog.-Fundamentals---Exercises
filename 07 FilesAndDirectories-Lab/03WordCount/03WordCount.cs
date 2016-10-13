using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            var separators = "\n\r,;:.!()\"?-/\\ [] ".ToArray();
            string[] inputText = File.ReadAllText("text.txt").ToLower().Split(separators,StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCnt = new Dictionary<string, int>();

            foreach (var oneWordFromWords in words)
            {
                wordCnt[oneWordFromWords] = 0;// fil the dictionary with key and value =0
            }

            foreach (var oneWordFromInputText in inputText)
            {
                if (wordCnt.ContainsKey(oneWordFromInputText))
                {
                    wordCnt[oneWordFromInputText]++;
                }
            }

            foreach (var item in wordCnt.OrderBy(p=>-p.Value))
            {
                File.AppendAllText("output.txt", string.Format("{0} - {1}{2}", item.Key, item.Value, Environment.NewLine));
            }


            

            


        }
    }
}
