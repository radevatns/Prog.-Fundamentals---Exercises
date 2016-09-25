using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        bool result = false;
        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            int tempNum = i;
            while (tempNum > 0)
            {
                sum += tempNum % 10;
                tempNum = tempNum / 10;
            }
            result = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{i} -> {result}");
            sum = 0;
        }
    }
}

