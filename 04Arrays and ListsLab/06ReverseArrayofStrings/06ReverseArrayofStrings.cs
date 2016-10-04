using System;

    class Program
    {
        static void Main()
        {
        string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length/2; i++)
            {
            string temp = input[i];
            input[i] = input[input.Length - 1 - i];
            input[input.Length - 1 - i] = temp;

        }
        Console.Write(string.Join(" ", input));
    }
    }

