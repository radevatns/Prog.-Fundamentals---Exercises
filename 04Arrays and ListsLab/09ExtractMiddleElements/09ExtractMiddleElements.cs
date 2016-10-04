using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (inputArr.Length % 2 ==0)//even 2 4 6
            GetTwoElements(inputArr);
        else
        {
            if (inputArr.Length == 1)//take only 1 element
                Console.WriteLine("{ "+ inputArr[0]+" }");
            else
                GetThreeElements(inputArr);
        }
    }
    private static void GetThreeElements()
    {
        throw new NotImplementedException();
    }

    private static void GetTwoElements(int [] inputArr)
    {
        int[] arrTwoElements = new int[2];
        
            arrTwoElements[0] = inputArr[(inputArr.Length / 2)-1];
            arrTwoElements[1] = inputArr[inputArr.Length / 2];
        Console.WriteLine("{ "+ string.Join(",",arrTwoElements) + " }");
        
    }
    private static void GetThreeElements(int [] inputArr)
    {
        int[] arrThreeElemens = new int[3];
        arrThreeElemens[0]= inputArr[(inputArr.Length / 2) - 1];
        arrThreeElemens[1] = inputArr[(inputArr.Length / 2)];
        arrThreeElemens[2] = inputArr[(inputArr.Length / 2) + 1];
        Console.WriteLine("{ "+string.Join(",", arrThreeElemens)+" }");
    }
}