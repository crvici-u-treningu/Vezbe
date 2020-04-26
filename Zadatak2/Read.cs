using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak1
{
    // ova klasa sluzi da olaksa ucitavanje brojeva i boolova
    public static class Read
    {
        // ucitava string sa tastature
        public static string String()
        {
            return Console.ReadLine();
        }

        // ucitava broj
        // primer: int x = Read.Int()
        public static int Int()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        // ucitava bool (u bilo kom od sledecih oblika: T, true, yes, 1)
        // primer: bool x = Read.Bool()
        public static bool Bool()
        {
            string s = Console.ReadLine().Trim().ToUpper();
            return (s == "T" || s == "TRUE" || s == "1" || s == "YES");
        }

        // ucitava decimalni broj
        // primer: float x = Read.Float()
        public static float Float()
        {
            return (float)Convert.ToDouble(Console.ReadLine());
        }
    }
}
