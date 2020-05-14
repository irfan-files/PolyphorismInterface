using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Printer: \n1. Epson\n2. Canon\n3. LaserJet");

            Console.Write("\nNomor Printer [1 ... 3] : ");
            int pilihPrinter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            IPrinterWindows printer = new PrinterWindows();

            if (pilihPrinter > 0 && pilihPrinter < 4)
            {
                if (pilihPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (pilihPrinter == 2)
                {
                    printer = new Canon();
                }
                else
                {
                    printer = new LaserJet();
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid \n");
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }

    interface IPrinterWindows
    {
        void Show();
        void Print();
    }

    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }

    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }

    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
    }

    class PrinterWindows : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("Printer Windows printing... ");
        }
    }



}