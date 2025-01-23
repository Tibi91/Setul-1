using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]);
            if (IsPrime(n))
            {
                Console.WriteLine("prim"); 
            }
            else
            {
                Console.WriteLine("nu este prim");
            }
            Console.ReadKey();
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
