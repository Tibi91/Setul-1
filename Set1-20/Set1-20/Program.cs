using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.in");
            string[] str = load.ReadLine().Split(' ');
            int m = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i]) % 2 == 0)
                {
                    m++;
                }
            }
            Console.Write(m);
            Console.ReadKey();
        }
    }
}
