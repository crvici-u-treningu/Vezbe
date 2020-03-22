using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    public class NegPos
    {
        public static bool DaLiJeJedanPozitivanDrugiNe(int a, int b)
        {
            // ovde napisati funkciju koja ce da vrati true ako je jedno od
            // argumenata pozitivno, a drugo nije pozitivno.

            // primer #1: a = 5, b = -5     ==>     true, a je pozitivno, b je negativno
            // primer #2: a = -5, b = 5     ==>     true, b je pozitivno, a je negativno
            // primer #3: a = -5, b = -3    ==>     false, oba su negativna
            // primer #4: a = 5, b = 5      ==>     false, oba su pozitivna
            // primer #5: a = 0, b = 5      ==>     true, b je pozitivan, a nije pozitivan
            // primer #6: a = 0, b = 0      ==>     false, oba su nula, pa nijedan nije pozitivan

            return false;
        }
    }
}
