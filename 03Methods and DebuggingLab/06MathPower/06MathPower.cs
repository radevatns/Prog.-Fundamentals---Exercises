using System;

    class Program
{
        static void Main(string[] args)
        {
        double baseNum = double.Parse(Console.ReadLine());
        double powerNum = double.Parse(Console.ReadLine());
        mathPower(baseNum,powerNum);
        double resultOfPower = mathPower(baseNum, powerNum);
        Console.WriteLine(resultOfPower);
        }
    static double mathPower(double baseNum, double powerNum)
    {
        return Math.Pow(baseNum, powerNum);
    }
}
