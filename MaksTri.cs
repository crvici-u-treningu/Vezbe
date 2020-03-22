using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    class MaksTri
    {
        public static int DajMaksTri(int a, int b, int c)
        {
            if (a > b && a > c)
            { 
                return a;
            }
            
            {
                if (b > c && b > a)
                {
                    return b;
                }
            
                if (c > a && c > b)
                {
                    return c;
                }
            }
            return a;
        }
    }
}
