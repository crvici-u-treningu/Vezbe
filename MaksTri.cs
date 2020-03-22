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
                Console.WriteLine("a");
            }
            
            {
                if (b > c && b > a)
                {
                    Console.WriteLine("b");
                }
            
                if (c > a && c > b)
                {
                    Console.WriteLine("c");
                }
            }
            return 0;
        }
    }
}
