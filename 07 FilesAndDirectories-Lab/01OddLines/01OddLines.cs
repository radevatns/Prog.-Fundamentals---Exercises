using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01OddLines
{
    class Program
    {
        static void Main(string[] args)
        {//1st solution.tested and work
            //string[] text = File.ReadAllLines("input.txt");

            //for (int i = 1; i < text.Length; i+=2)
            //{
            //    File.AppendAllText("output.txt",text[i]+Environment.NewLine);
            //}
            //2nd solution see bottom.Tested and work
            string[] text = File.ReadAllLines("input.txt");
            File.WriteAllLines("output.txt", text.Where((line,index) => index % 2 == 1));
        }
    }
}


