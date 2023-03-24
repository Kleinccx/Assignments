using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibleby11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            string nStr = Console.ReadLine();
            int n = int.Parse(nStr);

            int t = 0;
            for (int i = 0; i < nStr.Length; i++)
            {
                int digit = int.Parse(nStr[i].ToString());
                if (i % 2 == 0)
                {
                    t += digit;
                }
                else
                {
                    t -= digit;
                }
            }

            if (t % 11 == 0)
            {
                Console.WriteLine("{0} is divisible by 11.", n);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 11.", n);
            }
            }
    }
}
