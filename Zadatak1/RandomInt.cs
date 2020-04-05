using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak1
{
    public static class RandomInt
    {
        private static readonly Random r = new Random();

        public static int GetNew(int min, int max)
        {
            return r.Next(min, max + 1);
        }
    }
}
