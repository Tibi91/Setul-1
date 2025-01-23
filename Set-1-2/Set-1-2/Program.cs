using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            double a = double.Parse(S[0]);
            double b = double.Parse(S[1]);
            double c = double.Parse(S[2]);

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($" x1 = {x1}, x2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($" x = {x}");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii reale.");
                }
            }
            Console.ReadKey();
        }
    }
}
