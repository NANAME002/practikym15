using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {/// <summary>
     ///  Одна штука некоторого товара стоит 20,4 руб. 
     ///  Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            double pricePerItem = 20.4;

       
            Console.WriteLine("Количество\tСтоимость");
            Console.WriteLine("-------------------------");

            
            for (int quantity = 2; quantity <= 20; quantity++)
            {
                double totalCost = CalculateTotalCost(pricePerItem, quantity);
                Console.WriteLine($"{quantity}\t\t{totalCost:F2} руб.");
                Console.ReadKey();
            }
        }

       
        static double CalculateTotalCost(double pricePerItem, int quantity)
        {
            return pricePerItem * quantity;
        }
    }

}

