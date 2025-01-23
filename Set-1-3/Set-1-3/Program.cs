using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' '); 
            int n = int.Parse(S[0]);
            int k = int.Parse(S[1]);    
            if ( n % k == 0)
            {
                Console.WriteLine("Da");
            }
            else
            {
                Console.WriteLine("Nu");
            }
            Console.ReadKey();
        }
    }
}
