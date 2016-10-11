using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> inputWordsList = Console.ReadLine().Split(' ').ToList();Split(separators, StringSplitOptions.RemoveEmptyEntries)   Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries
            //string [] inputWordsArr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] inputWordsArr = Console.ReadLine().Split(' ').ToArray();
                Random rnd = new Random();

            for (int i = 0; i < inputWordsArr.Length-3; i++)
            {
                int randomIndex = rnd.Next(inputWordsArr.Length);
                string oldValue = inputWordsArr[i];
                inputWordsArr[i] = inputWordsArr[randomIndex];
                inputWordsArr[randomIndex] = oldValue;
            }
            Console.WriteLine(string.Join(" \n", inputWordsArr));

        }
    }
}
