using System;

class Program
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        int years = centuries * 100;
        uint days = (uint)(years * 365.2422);
        ulong hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong miliSeconds = seconds * 1000;
        ulong microSecunds = miliSeconds * 1000;
        decimal nanoSeconds = (decimal)microSecunds * 1000;// be careful with ulong and decimal

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, miliSeconds,microSecunds, nanoSeconds);
      }
}