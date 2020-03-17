﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    public class Test
    {
        public static void PokreniTestoveZa<T>()
        {
            static string MinH(int min)
            {
                return $"{min / 60}h {min % 60}min";
            }

            static bool Prestupna(int broj)
            {
                return ((broj % 4 == 0 && broj % 100 != 0) || (broj % 400 == 0));
            }

            if (typeof(T) == typeof(Vreme))
            {
                foreach (int min in new int[10] { 0, 3, 40, 60, 65, 110, 120, 720, 1244, 2000 })
                {
                    var dobro = MinH(min);
                    var test = Vreme.MinUSate(min);
                    if (dobro == test)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"[:)]\t\t{min} minuta je {test}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[:(]\t\t{min} minuta je {dobro}, ali vasa metoda kaze da je {test}.");
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(typeof(T) == typeof(MaksTri))
            {
                foreach (var brojevi in new Tuple<int, int, int>[3] { 
                    Tuple.Create(1, 1, 1), 
                    Tuple.Create(1, 2, 3), 
                    Tuple.Create(2, 112, 0) })
                {
                    var test = MaksTri.DajMaksTri(brojevi.Item1, brojevi.Item2, brojevi.Item3);
                    var dobro = Math.Max(brojevi.Item1, Math.Max(brojevi.Item2, brojevi.Item3));
                    if (dobro == test)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"[:)]\t\tOd brojeva {brojevi.Item1}, {brojevi.Item2}, i {brojevi.Item3} najveci je {dobro}.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[:)]\t\tOd brojeva {brojevi.Item1}, {brojevi.Item2}, i {brojevi.Item3} najveci je {dobro}, a vi ste rekli {test}.");
                    }
                }
            }
        }
    }
}