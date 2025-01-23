using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int y1 = int.Parse(S[0]);   
            int y2 = int.Parse(S[1]);
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine(i+" este un an bisect");
                }
            }
            Console.ReadKey();
        }
    }
}
