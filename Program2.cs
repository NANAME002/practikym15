using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
            /// </summary>
            /// <param name="args"></param>
            int[] randomNumbers = GenerateRandomNumbers(10, -40, 40);

            Console.WriteLine("Случайные числа:");
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
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
    }
}
