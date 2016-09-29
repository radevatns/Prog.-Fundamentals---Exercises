using System;

    class Program
    {
        static void Main()
        {
        printReceipt();
        }

    private static void printReceipt()
    {
        printReceiptHeader();
        printReceiptBill();
        printReceiptFooter(); 
    }

    private static void printReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT\n------------------------------");   
    }
    private static void printReceiptBill()
    {
        Console.WriteLine("Charged to____________________\nReceived by___________________");
    }
    static void printReceiptFooter()
    {
        Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }
}