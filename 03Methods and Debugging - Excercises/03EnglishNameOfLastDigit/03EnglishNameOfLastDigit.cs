using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());

        var result = GetEnglishName(inputNum);
        Console.WriteLine(result);
        
    }

    private static object GetEnglishName(long inputNum)
    {
        var lastDigit = Math.Abs(inputNum % 10);
        var nameOfLastDigit = "";
        switch (lastDigit)
        {
            case 1:
                nameOfLastDigit = "one";    
                break;
            case 2:
                nameOfLastDigit = "two";
                break;
            case 3:
                nameOfLastDigit = "three";
                break;
            case 4:
                nameOfLastDigit = "four";
                break;
            case 5:
                nameOfLastDigit = "five";
                break;
            case 6:
                nameOfLastDigit = "six";
                break;
            case 7:
                nameOfLastDigit = "seven";
                break;
            case 8:
                nameOfLastDigit = "eight";
                break;
            case 9:
                nameOfLastDigit = "nine";
                break;
            case 0:
                nameOfLastDigit = "zero";
                break;
            default:
                break;
        }
        return nameOfLastDigit;
    }
}
