using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {/// <summary>
     /// Генерируется 8 случайных целых чисел в интервале (–30, 30). 
     /// Выводятся эти числа и сообщения: отрицательное – положительное, четное – нечетное (for, if).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            int[] randomNumbers = GenerateRandomNumbers(8, -30, 30);

            Console.WriteLine("Случайные числа и их характеристики:");
            foreach (int number in randomNumbers)
            {
                string characteristics = DetermineCharacteristics(number);
                Console.WriteLine($"{number} - {characteristics}");
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

        
        static string DetermineCharacteristics(int number)
        {
            string sign = number < 0 ? "отрицательное" : "положительное";
            string parity = number % 2 == 0 ? "четное" : "нечетное";

            return $"{sign}, {parity}";
            
        }
    }
}
