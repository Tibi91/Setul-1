using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]); 
            int k = int.Parse(S[1]);
            int r1;
            int r2 = 1;
            int num = 0; 
            for (int i = 0; i < k; i++)
            {
                r1 = (n / r2) % 10;
                r2 = r2 * 10;
                num = r1; 
            }
            Console.WriteLine(num); 
            Console.ReadKey();
        }
    }
}
