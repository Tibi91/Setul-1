using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' '); 
            int n = int.Parse(S[0]);
            int a = int.Parse(S[1]);
            int b = int.Parse(S[2]);
            for (int i = a; i <= b; i++)
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
