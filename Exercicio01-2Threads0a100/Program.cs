using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio01_2Threads0a100.Apresentacao
{
    public class Program
    {
        static readonly int fifty = 50;
        static readonly int oneHundred = 100;
        static void Main(string[] args)
        {
            Thread threadZeroToFifty = new Thread(PrintZeroToFifty);
            Thread threadFiftyOneToOneHundred = new Thread(PrintFiftyOneToOneHundred);

            threadZeroToFifty.Start();
            threadFiftyOneToOneHundred.Start();

            Console.ReadKey();
        }

        static void PrintZeroToFifty()
        {
            Console.WriteLine("Iniciando 1ª Thread:");
            Thread.Sleep(1000);

            for (int i = 0; i < fifty; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("1ª Thread finalizada");
        }

        static void PrintFiftyOneToOneHundred()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Iniciando 2ª Thread:");
            Thread.Sleep(2000);            

            for (int i = fifty; i <= oneHundred; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("2ª Thread finalizada");
        }
    }
}
