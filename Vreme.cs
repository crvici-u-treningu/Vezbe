using System;

namespace Vezbe
{
    public class Vreme
    {
        // primer: 145min -> 2h 25minuta
        public static string MinUSate(int x)
        {
            int h = x/60; //... ovde menjaj
            int m = x%60; //... ovde menjaj
            //
            

			//pogledaj dropbox, kako koristi podeljeno (/) i ostatak (%)
            return $"{h}h {m}min";
        }
    }
}