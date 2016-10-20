using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FixEmails
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> inputDict = new Dictionary<string, string>();
            string inputName = Console.ReadLine();
            string[] exceptions = "us US uk UK".Split(' ').ToArray();
            //var exceptions = ""us US uk UK.ToArray(); 
            while (!inputName.Equals("stop"))
            {
                //var inputEmail = Console.ReadLine().Split('.').ToArray();
                var email = Console.ReadLine();
                var emailDomain = email.Substring(email.Length - 2).ToLower();
                if (!emailDomain.Equals("uk") && !emailDomain.Equals("us"))
                //if (inputEmail[1].Contains(exceptions[0]));// && !inputEmail[1].Contains(exceptions[1]));
                //if (!inputEmail[1].Equals("uk"));// && !inputEmail[1].ToUpper().Equals("US"));Not work
                {
                    if (!inputDict.ContainsKey(inputName))
                    {
                        inputDict.Add(inputName, email);
                    }
                }
                inputName = Console.ReadLine();
            }
            foreach (KeyValuePair<string,string> pair in inputDict)
            {
                Console.WriteLine("{0} -> {1}",pair.Key, pair.Value);
            }
        }
    }
}
