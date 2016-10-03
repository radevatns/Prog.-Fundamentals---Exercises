using System;

    class Program
    {
        static void Main(string[] args)
        
    {
        int n = int.Parse(Console.ReadLine());
        GetMultipleOfEvensAndOdds(n);
        int finalResult = GetMultipleOfEvensAndOdds(Math.Abs(n));// without math.abs not work for n< 0
        Console.WriteLine(finalResult);
    }

    private static int GetMultipleOfEvensAndOdds(int n)
    {
        int sumEvens = GetSumOfEvenDigits(n);
        int sumOdd = GetSumOfOddDigits(n);
        int multiply = sumOdd * sumEvens;
        return multiply;
    }

    private static int GetSumOfOddDigits(int n)
    {
        int sum = 0;
        while (n>0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 !=0)
                sum += lastDigit;
            n = n / 10;
        }
        return sum;
    }

    private static int GetSumOfEvenDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 == 0)
                sum += lastDigit;
            n = n / 10;
        }
        return sum;
    }
}