using System;

    class Program
    {
        static void Main()
        {
        string hexValue = Console.ReadLine();
        var decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine(decValue);
        // to convert Decimal to HEX
        /*
        int decSecValue = int.Parse(Console.ReadLine());
        string hexSecValue = decSecValue.ToString("X");
        Console.WriteLine("0x"+hexSecValue);// if write with placeholder -> not work
        */
    }
}