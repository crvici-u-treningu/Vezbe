using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    class MaksTri
    {
        public static int DajMaksTri(int a, int b, int c)
        {
            int najveci = a;
            if (najveci < b) najveci = b;
            if (najveci < c) najveci = c;
            return najveci;
        }
    }
}
