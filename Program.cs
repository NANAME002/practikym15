using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat();
            Console.ReadKey();

        }
        public static void Repeat()
        {
            double price = 20.4;
            for (int i = 2; i<=20;i++)
            {
                Console.WriteLine($"{i}шт.={price * i}руб");
            }
        }
    }
}
