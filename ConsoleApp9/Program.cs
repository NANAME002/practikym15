using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {/// <summary>
     /// Генерируется 10 случайных целых чисел в интервале (– 20, 20).
     /// Выводятся только положительные числа и сообщения: четное – нечетное (for, if).
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(10, -20, 20);

            Console.WriteLine("Положительные числа и их характеристики:");
            foreach (int number in randomNumbers)
            {
                if (number > 0) 
                {
                    string parity = DetermineParity(number);
                    Console.WriteLine($"{number} - {parity}");
                }
            }
            Console.ReadKey();
        }

     
        static int[] GenerateRandomNumbers(int count, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
            }

            return numbers;
        }

      
        static string DetermineParity(int number)
        {
            return number % 2 == 0 ? "четное" : "нечетное";
        }
    }
}
