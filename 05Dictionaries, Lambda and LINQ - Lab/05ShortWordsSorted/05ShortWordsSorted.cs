using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var separators = ". , : ; ( ) [ ] \" ' \\ / ! ?  .".ToArray();
            var inputList = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var distinctList = inputList.Distinct();
            var lengthList = distinctList.Where(s => s.Length < 5);
            var sortedList = lengthList.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortedList));*/
            // option 2
            char[] separators = new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            // or char[] separators = ".,:;()[]\"'!? ".ToCharArray();
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words
                .Where(w => w != "")
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct(); // remove repetition (povtorenie)
            Console.WriteLine(string.Join(", ", result));


        }
    }
}
