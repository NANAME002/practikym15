using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {/// <summary>
     ///  Генерируется 12 случайных целых чисел в интервале (-50,50).
     ///  Вывести эти числа и сообщения: отрицательное-положительное.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomNumbers(12, -50, 50);

            Console.WriteLine("Случайные числа и их характеристики:");
            foreach (int number in randomNumbers)
            {
                string result = DeterminePositiveNegative(number);
                Console.WriteLine($"{number} - {result}");
                Console.ReadKey();
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

        
        static string DeterminePositiveNegative(int number)
        {
            if (number > 0)
            {
                return "положительное";
            }
            else if (number < 0)
            {
                return "отрицательное";
            }
            else
            {
                return "ноль"; 
            }
        }
    }
    
}
