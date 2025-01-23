using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int y = int.Parse(S[0]);
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine(y + " este un an bisect"); 
            }
            else
            {
                Console.WriteLine(y + " nu este un an bisect");
            }
            Console.ReadKey();
        }
    }
}
