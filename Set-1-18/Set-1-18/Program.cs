using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');          
            int n = int.Parse(S[0]);

            if (n <= 1)
            {
                Console.WriteLine("Numarul trebuie sa fie mai mare decat 1.");
                return;
            }

            Factorize(n);

            Console.ReadKey();
        }
        static void Factorize(int n)
        {
            bool firstFactor = true;

            for (int i = 2; i * i <= n; i++)
            {
                int power = 0;

                while (n % i == 0)
                {
                    n /= i;
                    power++;
                }

                if (power > 0)
                {
                    if (!firstFactor)
                        Console.Write(" x ");
                    Console.Write($"{i}^{power}");
                    firstFactor = false;
                }
            }

            if (n > 1)
            {
                if (!firstFactor)
                    Console.Write(" x ");
                Console.Write($"{n}^1");
            }

            Console.WriteLine();
        }
    }
}
