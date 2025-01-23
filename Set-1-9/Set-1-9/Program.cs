using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
