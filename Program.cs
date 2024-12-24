using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {/// <summary>
     ///  Генерируются 15 случайных целых чисел в интервале (-20, 30).
     ///  Вывести эти числа и подсчитать количество положительных чисел.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            int[] randomNumbers = GenerateRandomNumbers(15, -20, 30);

            Console.WriteLine("Случайные числа:");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            
            int positiveCount = CountPositiveNumbers(randomNumbers);
            Console.WriteLine($"Количество положительных чисел: {positiveCount}");
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

        static int CountPositiveNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
