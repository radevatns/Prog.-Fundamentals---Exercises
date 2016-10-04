using System;
using System.Linq;
class Program
{
    static void Main()
    {
        
        string[] input = Console.ReadLine().Split();
        double[] numbers = new double[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            double[] roundArr = new double[numbers.Length];
            roundArr[i] = Math.Round(numbers[i],MidpointRounding.AwayFromZero);
            Console.WriteLine("{0} => {1}", numbers[i],roundArr[i]);
        }
    }
}
