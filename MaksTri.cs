using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    class MaksTri
    {
        public static int DajMaksTri(int a, int b, int c)
        {
            /*
             * a=5, b=3, c=2
             */
            if (a > b)
            {
                if (a > c)
                    return a;
                else return c;

            }
            else
            {
                if (b > c)
                    return b;
                else return c;
            }
           
        }
    }
}
