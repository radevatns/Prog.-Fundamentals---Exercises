using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        int cnt = 0;
        int tempCnt = 0;
        string[] firstInputStr = Console.ReadLine().Split(' ');
        string[] secInputStr = Console.ReadLine().Split(' ');
        int minLenght = Math.Min(firstInputStr.Length, secInputStr.Length);
        int maxLenght = Math.Max(firstInputStr.Length, secInputStr.Length);
            for (int i = 0; i < minLenght; i++)
            {   if (firstInputStr[i] == secInputStr[i])
                    {
                        tempCnt++;
                    if (i == minLenght - 1)
                        {
                            cnt = tempCnt;
                            tempCnt = 0;
                        }
                    }
                else
                {
                    if (tempCnt>cnt)
                        {
                            cnt = tempCnt;
                            tempCnt = 0;
                        }
                }
            }
       
        for (int j = 1; j <= minLenght; j++)
        {
            if (firstInputStr[firstInputStr.Length-j] == secInputStr[secInputStr.Length - j])
            {
                tempCnt++;
                    if (j == minLenght)
                        cnt = tempCnt;
            }
            else
            {
                if (tempCnt > cnt)
                {
                    cnt = tempCnt;
                    tempCnt = 0;
                }
            }
        }
        Console.WriteLine(cnt);
       } 
    }