using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak1
{
    class Igra 
    {
        static void Main(string[] args)
        {
            int bingo = RandomInt.GetNew(1, 100);
            int n = 0;
            int pokusaj = 0;
            do
            {
                Console.Write("Pogodi broj: ");
                n = Read.Int();
                pokusaj++;

                if (bingo == n)
                {
                    Console.Write($"Bravo! Rešiste iz {pokusaj} koraka");
                    return;
                }
                else
                {
                    if (bingo > n)
                        Console.WriteLine("Veće! ");
                    else Console.WriteLine("Manje! ");
                }
            }
            while (bingo != n);
        }
    }
}
