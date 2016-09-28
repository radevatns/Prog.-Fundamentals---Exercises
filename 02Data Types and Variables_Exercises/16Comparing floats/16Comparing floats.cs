using System;

class Program
{
    static void Main()
    {
        double aNum = double.Parse(Console.ReadLine());
        double bNum = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double difference = Math.Abs(aNum - bNum);
        bool isLowerThanEps = true;

        if (difference >= eps)
            {
            isLowerThanEps = false;
            }
        Console.WriteLine(isLowerThanEps);
    }
}