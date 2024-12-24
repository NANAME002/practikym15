using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {/// <summary>
     /// Напишите программу, которая вычисляет сумму всех целых чисел от 1 до N,
     /// где N вводится пользователем.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N:");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                int sum = CalculateSum(N);
                Console.WriteLine($"Сумма всех целых чисел от 1 до {N} равна {sum}.");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите положительное целое число.");
            }
            Console.ReadKey();
        }


        static int CalculateSum(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
