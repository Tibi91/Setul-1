using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);
            int temp;
            temp = b;
            b = a;
            a = temp; 
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
