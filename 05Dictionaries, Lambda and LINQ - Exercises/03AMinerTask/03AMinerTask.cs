using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
    Dictionary<string, long> resources = new Dictionary<string, long>();

    string resourcesType = Console.ReadLine();
        while (!resourcesType.Equals("stop"))
        {
            long resourceQuantity = long.Parse(Console.ReadLine());

            if (!resources.ContainsKey(resourcesType))
            {
                resources.Add(resourcesType, 0);
                resources[resourcesType] += resourceQuantity;
            }
             // fill the value of key
            else
	        {
                resources[resourcesType] += resourceQuantity;
            }
        resourcesType = Console.ReadLine();

        }
        foreach (KeyValuePair<string, long> item in resources)
        {
            Console.WriteLine("{0} -> {1}",item.Key,item.Value);
        }
    }
}
