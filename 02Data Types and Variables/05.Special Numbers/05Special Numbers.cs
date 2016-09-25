using System;
    class Program
    {
        static void Main()
        {
        var n = int.Parse(Console.ReadLine());
        //Console.WriteLine(n%10);
        for (int i = 1; i <= n; i++)
        {
            int num = i;
            int sum = 0;
            int lastDigit = 0;
            while (num !=0)
            {
                lastDigit = num % 10;// return last digit
                sum = sum + lastDigit; // add to result
                num = num / 10;
            }
            if (sum == 5 ||sum == 7 || sum == 11 )
            {
                Console.WriteLine("{0} -> True", i);
            }
            else
            {
                Console.WriteLine("{0} -> False", i);
            }            
        }
    }
    }