using System;

class Program
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        for (int i = 2; i <= inputNum; i++)
        {
            bool isTrue = true;
            for (int k = 2; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    isTrue = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isTrue}");
        }

    }
}