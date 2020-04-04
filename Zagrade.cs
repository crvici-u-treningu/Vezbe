using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    public class Zagrade
    {
        /*
                    "((()))"
        b = 0        123210  da li je 0? da :)

                    "((())"
        b = 0        12321   da li je 0? ne :(

                    "())"
        b = 0        10-1    da li je 0? ne :(

                     ")))))))"
                     -10

                    visak jednih ili drugih na kraju = :(
                    1 + (-1) = 0
                    (     )
         */
        public static bool DaLiSuSveZagradeZatvorene(string zagrade)
        {
            int indeks = 0;
            int balans = 0;
            int duzina = zagrade.Length;

            while (indeks < duzina)
            {
                if (zagrade[indeks] == '(')
                    balans++;
                else if (zagrade[indeks] == ')')
                    balans--;

                indeks++;
            }
            return (balans == 0);
        }
    }
}
