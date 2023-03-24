using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());

            string evenNumbers = ""; 
            int sum = 0; 
            int num = start; 
            do
            {
                if (num % 2 == 0)
                { 
                    evenNumbers += num + " "; 
                    sum += num; 
                }
                num++; 
            } while (num <= end);

            Console.WriteLine("\nEven Numbers: " + evenNumbers);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
