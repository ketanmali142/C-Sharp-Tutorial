using System;

namespace Chapter_Inheritance
{
    interface IPrintable
    {
        void Print();
    }

    interface IScannable
    {
        void Scan();
    }

    class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }

    class MultipleInheritance
    {
        public static void Run()
        {
            Console.WriteLine("Multiple Inheritance:");
            PrinterScanner scanner = new PrinterScanner();
            scanner.Print();
            scanner.Scan();
            Console.WriteLine();
        }
    }
}
