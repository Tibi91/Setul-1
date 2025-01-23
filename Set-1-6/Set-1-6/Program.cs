using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);
            int c = int.Parse(S[2]);
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("da");
            }
            else
            {
                Console.WriteLine("nu");
            }
            Console.ReadKey();
        }
    }
}
