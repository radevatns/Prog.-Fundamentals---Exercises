using System;

    class Program
    {
        static void Main()
        {
        float distanceMeter = int.Parse(Console.ReadLine());
        float hours = int.Parse(Console.ReadLine());
        float minutes = int.Parse(Console.ReadLine());
        float seconds = int.Parse(Console.ReadLine());

        float allTimeSec = (hours * 60 + minutes) * 60 + seconds;
        
        float meterPerSeconds = distanceMeter / allTimeSec;   // S = V*T or V = S/T
        float kmPerHour = (distanceMeter/1000) / (allTimeSec /3600);
        float milesPerHour = (distanceMeter/1609) / (allTimeSec / 3600);
        Console.WriteLine("{0}\n{1}\n{2}", meterPerSeconds, kmPerHour, milesPerHour);

    }
    }
