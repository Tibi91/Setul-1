using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            double a = double.Parse(S[0]);
            double b = double.Parse(S[1]);
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia nu poate fi rezolvata");
                }
                else
                {
                    Console.WriteLine("x = 0");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("x = " + x); 
            }
            Console.ReadKey();
        }
    }
}
