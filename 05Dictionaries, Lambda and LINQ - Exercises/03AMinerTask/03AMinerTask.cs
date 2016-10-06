using System;
using System.Collections.Generic;
using System.Linq;



    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, long> resources = new Dictionary<string, long>();

        string resourcesType = Console.ReadLine();
        while(!resourcesType.Equals("stop"))
        {
            long resourceQuantity = long.Parse(Console.ReadLine());
            if (resources.Contains(resourcesType))
            {
                Console.WriteLine();
            }

            resourcesType = Console.ReadLine();

        }
    }
    }
