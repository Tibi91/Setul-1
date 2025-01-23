using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]);

            int original = n;  
            int reversed = 0;

            while (n != 0)
            {
                int digit = n % 10;        
                reversed = reversed * 10 + digit;
                n /= 10;                 
            }

            original = reversed;
        }
    }
}
