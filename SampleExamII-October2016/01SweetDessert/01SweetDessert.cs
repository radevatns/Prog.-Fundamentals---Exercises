using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            decimal numberOfGuests = decimal.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            decimal portion = Math.Ceiling(numberOfGuests / 6);//, trancate
            decimal totalPrice = portion * ((2 * priceOfBanana) + (4 * priceOfEggs) + (0.2m * priceOfBerries));
            if (totalPrice <= amountOfCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", totalPrice);
                
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",(totalPrice-amountOfCash));
            }                         
        }
    }
}
