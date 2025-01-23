using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);    
            int c = int.Parse(S[2]);
            int[] numere = { a, b, c };
    
            Array.Sort(numere);
            Console.Write(numere[0]);
            Console.Write(" ");
            Console.Write(numere[1]);
            Console.Write(" ");
            Console.Write(numere[2]);
            Console.ReadKey();
        }
    }
}
