using System;

    class Program
    {
        static void Main(string[] args)
        {
        int numOfPrice = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numOfPrice-1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double deviation = GetPercentOfChangePrice(firstPrice, nextPrice);
            bool isDiffOverTresh = isDeviationOverTresh(deviation, threshold);
            string printMessageForResult = CheckDeviationOfPrice(nextPrice, firstPrice, deviation, isDiffOverTresh);
            Console.WriteLine(printMessageForResult);
            firstPrice = nextPrice;
        }
    }
    private static string CheckDeviationOfPrice(double newPrice, double prevPrice, double deviation, bool isDiffOverTresh)
    {
        string messagesForPrint = "";
        if (deviation == 0)
        {
            messagesForPrint = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!isDiffOverTresh)
        {
            messagesForPrint = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prevPrice, newPrice, deviation*100);
        }
        else if (isDiffOverTresh && (deviation > 0))
        {
            messagesForPrint = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prevPrice, newPrice, deviation*100);
        }
        else if (isDiffOverTresh && (deviation < 0))
            messagesForPrint = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prevPrice, newPrice, deviation*100);
        return messagesForPrint;
    }

    private static bool isDeviationOverTresh(double calculateDeviation, double inputTreshold)
    {
        if (Math.Abs(inputTreshold) <= Math.Abs(calculateDeviation))//smisal ot math.abs??//TO DO why work with to Math.Abs
            return true;
        return false;
    }

    private static double GetPercentOfChangePrice(double firstPrice, double nextPrice)
    {
        double deviationChange = ((nextPrice - firstPrice) / firstPrice);//*100
        return deviationChange;
    }
}