using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = File.ReadAllLines("Input.txt");

            for (int i = 0; i < inputText.Length; i++)
            {
                File.AppendAllText("output.txt",$"{i+1}. {inputText[i]}{Environment.NewLine}");
            }

        }
    }
}
