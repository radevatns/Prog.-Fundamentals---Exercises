using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06UserLogs
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string ip = input[0];// this is IPwith IP front of ip
            string message = input[1];
            string name = input[2];
            string[] finalIPArr = ip.Split('=').ToArray();
            string finalIP = finalIPArr[1];
            //Console.WriteLine(finalIP);
            string[] finalNameArr = name.Split('=').ToArray();
            string finalName = finalNameArr[1]; // this is user name 

            var countDict = new SortedDictionary<string, int>();
            while (!input.Contains("end"))
            {
                if (countDict.ContainsKey(finalIP))
                {
                    countDict[finalIP]++;
                }
                else
                {
                    countDict.Add(finalIP, 1);
                }
                input = Console.ReadLine().Split(' ').ToArray();

            }
            foreach (KeyValuePair<string, int> pair in countDict)
            {
                Console.WriteLine("{0} =>{1}", pair.Key, pair.Value);

            }
            
            
        }


        }
    }
}
