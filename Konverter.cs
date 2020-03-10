using System;

namespace Vezbe
{
    public class Konverter
    {
        //tc->PretvoriUFarenhajte->tf
        //tc*9/5+32

        public static int PretvoriUFarenhajte(int tc)
        {
            return tc * 9 / 5 + 32;
        }
        public static int PretvoriUCelzijuse(int tf)
        {
            return (tf - 32) * 5 / 9;
        }
    }
}