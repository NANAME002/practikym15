using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repeat();
            Console.ReadKey();

        }
        public static void Repeat()
        {
            Random random = new Random();
            for (int i =0; i <10; i++)
            {
                int number = random.Next(-40,40); 
                Console.WriteLine(number);

            }
        }
                
    }
}
