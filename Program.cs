using System;

namespace Vezbe
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int min in new int[6] { 3, 4, 5, 10, 110, 120 })
            {
                // Za domaci, neka ovo proradi:
                Console.WriteLine($"{min} minuta je {Vreme.MinUSate(min)}");
            }
        }
    }
}
