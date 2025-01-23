using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Set1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok = true; 
            string[] S = Console.ReadLine().Split(' ');
            int n = int.Parse(S[0]);
            int v1 = -1;
            int v2 = -1;
            while (n != 0)
            {
                int c = n % 10;
                if (v1 == -1) v1 = c;
                else if ((v2 == -1) && (c != v1)) v2 = c;
                else if ((v1 != c) && (v2 != c)) ok = false; 
            }
            Console.Write(ok);
            Console.ReadKey();
        }
    }
}
