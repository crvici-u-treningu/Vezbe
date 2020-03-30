using System;

namespace ConsoleApp2
{
    class Stringovi
    {
        // napisi program koji vraca true ako string pocinje slovom B
        static bool DaLiPocinjeSlovomB(string s)
        {
            return s.StartsWith("B");
        }

        static bool DaLiJeRecDuzaOdPetSlova(string s)
        {
            return s.Length > 5;
        }

        static bool DaLiRecSadrziSlovaXiY(string s)
        {
            return s.Contains("X") && s.Contains("Y");
        }

        static string IseciDrugoICetvrtoSlovo(string s)
        {
            // s =            
            //              012345....150    s.Length = 1
            // i =          ^
            // rezultat    "B"

            string rezultat = "";
            int i = 0;
            //    0 < 0
            while(i < s.Length)
// PETLJA            
            {
                if(i != 1 && i != 3)
                {
                                // !!!!!!
                    rezultat += s[i]; // s od i (i-to slovo u stringu s)
                }
                
                i++;
            }
// KRAJ
            return rezultat;
        }

        static void Main(string[] args)
        {
/*
            Console.WriteLine(DaLiPocinjeSlovomB("qweqwe"));
            Console.WriteLine(DaLiPocinjeSlovomB("Bilja i Milena"));

            Console.WriteLine(DaLiJeRecDuzaOdPetSlova("qwe"));
            Console.WriteLine(DaLiJeRecDuzaOdPetSlova("Bilja i Milena"));

            Console.WriteLine(DaLiRecSadrziSlovaXiY("qwe"));
            Console.WriteLine(DaLiRecSadrziSlovaXiY("Bilja i Milena"));
            Console.WriteLine(DaLiRecSadrziSlovaXiY("xX Bilja i Milena"));
            Console.WriteLine(DaLiRecSadrziSlovaXiY("Yy Bilja i Milena"));
            Console.WriteLine(DaLiRecSadrziSlovaXiY("xX Bilja i Milena Yy"));
*/
//                                                     0123
            Console.WriteLine(IseciDrugoICetvrtoSlovo("ABCDE")); // ACE
            Console.WriteLine(IseciDrugoICetvrtoSlovo("Biljana")); // Blana
            Console.WriteLine(IseciDrugoICetvrtoSlovo("B")); // Blana
        }
    }
}
