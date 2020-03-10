using System;
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

            if(typeof(T) == typeof(Vreme))
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
        }
    }
}
