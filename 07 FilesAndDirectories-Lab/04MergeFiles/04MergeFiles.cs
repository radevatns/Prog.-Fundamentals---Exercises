using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04MergeFiles
{
    class Program
    {
        static void Main()
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");
            for (int i = 0; i < firstFile.Length; i++)
                {
                File.AppendAllText(@"C:\Users\nasko\Desktop\mergerd.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }



            //File.WriteAllText(@"C:\Users\nasko\Desktop\mergerd.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            //File.WriteAllText("mergerd.txt", firstFile + Environment.NewLine + secondFile);

        }
    }
}
