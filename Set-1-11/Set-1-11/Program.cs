using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]);
            while (n != 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
