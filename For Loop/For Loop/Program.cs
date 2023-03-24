using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter column: ");
            int number2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number1; i++)
            {
                for (int j = 1; j <= number2; j++) 
                {
                    Console.Write("{0}\t", i * j); 
                }
                Console.WriteLine(); 
            }
        }
    }
}

