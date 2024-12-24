using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int number = 20;
            Repeat(count,number);
            Console.ReadKey();

        }
        public static void Repeat(int count, int number)
        {

            for (int i = 0; i < count; i++)
            {
                Console.Write(number);
                // Добавляем пробел после числа, если это не последнее число
                if (i < count - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }

}
