using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int tempNum = n;
        int sumOfEven = 0;
        int sumOfOdd = 0;
        while (tempNum != 0)
        {
            int lastDigit = tempNum % 10;
            if (lastDigit % 2 == 0)
            {
                sumOfEven += lastDigit;

                //Console.WriteLine(lastDigit + "even");// \2,4,6
            }
            else
            {
                sumOfOdd += lastDigit;
                //Console.WriteLine(lastDigit + "odd");//1 3 5
            }
            tempNum = tempNum / 10;
        }
        int finalMultiply = sumOfEven * sumOfOdd;
        Console.WriteLine(finalMultiply);
    }
}