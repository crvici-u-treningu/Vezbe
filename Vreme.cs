using System;

namespace Vezbe
{
    public class Vreme
    {
        // primer: 100min -> 1h 40minuta
        public static string MinUSate(int min)
        {
            int h = 0; //... ovde menjaj
            int m = 0; //... ovde menjaj
            
            return $"{h}h {m}min";
        }
    }
}