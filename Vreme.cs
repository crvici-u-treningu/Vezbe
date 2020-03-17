using System;

namespace Vezbe
{
    public class Vreme
    {
        // primer: 145min -> 2h 25minuta
        public static string MinUSate(int x)
        {
            int h = 60; //... ovde menjaj
            //x/h=a
            int a = x / h;
            int m = x - a*h; //... ovde menjaj
            //
            

			//pogledaj dropbox, kako koristi podeljeno (/) i ostatak (%)
            return $"{a}h {m}min";
        }
    }
}