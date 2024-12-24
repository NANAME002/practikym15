using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {/// <summary>
     /// Вывести четные двузначные числа и подсчитать их количество.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
         
            Console.WriteLine("Четные двузначные числа:");
            for (int number = 10; number <= 99; number++)
            {
                if (IsEven(number))
                {
                    Console.WriteLine(number);
                }
            }

            
            int count = CountEvenNumbers(10, 99);
            Console.WriteLine($"\nКоличество четных двузначных чисел: {count}");
            Console.ReadKey();
        }

       
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static int CountEvenNumbers(int start, int end)
        {
            int count = 0;
            for (int number = start; number <= end; number++)
            {
                if (IsEven(number))
                {
                    count++;
                }
            }
            return count;
        }
    }

}
