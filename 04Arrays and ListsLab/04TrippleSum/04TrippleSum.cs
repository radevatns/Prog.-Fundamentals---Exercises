using System;
using System.Linq;

    class Program
    {
        static void Main()
        {
        var numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool ifNoSuchTriplesExist = true;
        for (int left = 0; left < numsArr.Length; left++)
        {
            for (int right = left + 1; right < numsArr.Length; right++)
            {
                int sum = numsArr[left] + numsArr[right];
                
                    if (numsArr.Contains(sum))
                    {
                        Console.WriteLine($"{numsArr[left]} + {numsArr[right]} == {sum}");
                    ifNoSuchTriplesExist = false;
                    }
            }
        }
        if (ifNoSuchTriplesExist)
        {
            Console.WriteLine("No");
        }
    }
    }
