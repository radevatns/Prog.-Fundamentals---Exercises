using System;

    class Program
    {
        static void Main()
        {
        int numOfElement = int.Parse(Console.ReadLine());
        long[] array = new long[numOfElement];
        array[0] = 1;
        int k = int.Parse(Console.ReadLine());
        for (int i = 1; i < array.Length; i++)
        {
            long sum = 0;
            for (int m = i-k; m <= i-1; m++)
            {
                if (m>=0)
                    sum += array[m];
            }
            array[i] = sum;
        }
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i]+ " ");
      
        }
    } 