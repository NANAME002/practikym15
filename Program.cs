using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat();
            Console.ReadLine();
        }
        public static void Repeat()
        {
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int number = random.Next(-20, 30);
                Console.WriteLine(number);
                if (number > 0) count++;
                
            }
            Console.WriteLine($"количество положительных чисел= {count}");

        }
    }
}
