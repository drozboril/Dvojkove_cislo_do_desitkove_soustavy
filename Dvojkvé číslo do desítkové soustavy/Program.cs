using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte dvojkové číslo k převodu do desítkové soustavy");
            int bin = int.Parse(Console.ReadLine());
            int bin1 = bin;
            int i, j, k, l;
            i = bin / 1000; j = bin / 100 % 10; k = bin / 10 % 10; l = bin % 10;
            int dec = 0;
            int a = 1;
            if (i > 1 || j > 1 || k > 1 || l > 1)
            {
                Console.WriteLine("Chyba zadání");
            }
            else
            {
                while (bin > 0)
                {
                    dec += (a * (bin % 2));
                    bin = bin / 10;
                    a = a << 1;
                }
                Console.WriteLine("Zadané číslo {0} je v desítkové soustavě {1}", bin1, dec);
            }
            Console.ReadLine();
        }
    }
}