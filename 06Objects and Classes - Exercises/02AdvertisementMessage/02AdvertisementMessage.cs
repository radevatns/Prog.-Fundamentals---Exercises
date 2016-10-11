using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random rnd = new Random();
            for (int i = 0; i < inputNum; i++)
            {
                int randomPhrases = rnd.Next(0, phrases.Length);
                int eventsPhrases = rnd.Next(0, events.Length);
                int authorPhrases = rnd.Next(0, author.Length);
                int cityPhrases = rnd.Next(0, city.Length);
                Console.WriteLine($"{phrases[randomPhrases]} {events[eventsPhrases]} {author[authorPhrases]} - {city[cityPhrases]}.");
            }                
        }
    }
}
