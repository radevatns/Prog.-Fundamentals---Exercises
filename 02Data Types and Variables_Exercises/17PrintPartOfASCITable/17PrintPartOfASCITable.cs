using System;

class Program
{
    static void Main()
    {
    int startNum = int.Parse(Console.ReadLine());
    int endNum = int.Parse(Console.ReadLine());
        for (int asciiCode = startNum; asciiCode <= endNum; asciiCode++)
        {
            Console.Write((char)asciiCode + " ");
        }
    }
}