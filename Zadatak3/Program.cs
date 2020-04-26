using System;
using Zadatak1;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int a = Read.Int();
            Console.Write("Unesi broj: ");
            int b = Read.Int();

            //long rezutat = n * (n + 1) / 2; //O(1)
            //1 2 3 4 5 6 7 8 9
            //for (int i = 1; i <= n; i++) //O(n)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                //rezutat+=i; //O(1)
            }
            //Console.Write($"Zbir svih brojeva do {n} je: {rezutat} "); //O(1)
        }
    }
}
