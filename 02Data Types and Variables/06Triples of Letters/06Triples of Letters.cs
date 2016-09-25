using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int outSide = 0; outSide < n; outSide++)
        {
            char letterOut = (char)('a' + outSide);

            for (int mid = 0; mid < n; mid++)
            {
                char letterMid = (char)('a' + mid);

                for (int inSide = 0; inSide < n; inSide++)
                {
                    char letterIn = (char)('a' + inSide);

                    Console.WriteLine("{0}{1}{2}", letterOut, letterMid, letterIn);
                }
            }
        }
    }
}
