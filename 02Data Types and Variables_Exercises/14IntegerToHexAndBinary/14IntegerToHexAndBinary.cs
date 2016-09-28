using System;

class Program
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        string hexValue = decimalNumber.ToString("X");      //if use small "x" result will be print with small letter
        Console.WriteLine(hexValue);
        string binaryValue = Convert.ToString(decimalNumber, 2);// if change 2 with 8,10,16 change binary/ oct, decimal and HEX
        Console.WriteLine(binaryValue);
    }
}
 