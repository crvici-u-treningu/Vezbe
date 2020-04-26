using System;
using Zadatak1;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"unesi {i+1}. broj: ");
                 brojevi[i] = Read.Int();
            }
            for (int m = 9; m >= 0; m--)
                Console.WriteLine(brojevi[m]);
        }
    }
}
