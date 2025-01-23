using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Set_1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split(' ');
            int a = int.Parse(S[0]);
            int b = int.Parse(S[1]);
            int c = int.Parse(S[2]);
            int d = int.Parse(S[3]);
            int e = int.Parse(S[4]);
            
            if (a > b) { int temp = a; a = b; b = temp; }
            if (a > c) { int temp = a; a = c; c = temp; }
            if (a > d) { int temp = a; a = d; d = temp; }
            if (a > e) { int temp = a; a = e; e = temp; }

            if (b > c) { int temp = b; b = c; c = temp; }
            if (b > d) { int temp = b; b = d; d = temp; }
            if (b > e) { int temp = b; b = e; e = temp; }

            if (c > d) { int temp = c; c = d; d = temp; }
            if (c > e) { int temp = c; c = e; e = temp; }

            if (d > e) { int temp = d; d = e; e = temp; }


            Console.WriteLine($"Numerele în ordine crescătoare sunt: {a}, {b}, {c}, {d}, {e}");
        }
    }
}
