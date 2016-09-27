using System;

class Program
{
    static void Main()
    {
        string customText = Console.ReadLine();
        bool result = Convert.ToBoolean(customText);
        if (result == true)
        {
            Console.WriteLine("Yes");
        }
        if (result == false)
        {
            Console.WriteLine("No");
        }


    //string customText = Console.ReadLine();
    //    if (customText == "True")
    //    {
    //        Console.WriteLine("Yes");
    //    }
    //    if (customText == "False")
    //    {
    //        Console.WriteLine("No");
    //    }
    }
}