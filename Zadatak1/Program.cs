using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("daj mi jedan broj: ");
            int n = Read.Int();

            /*n = 5
1 2 3 4 5
2 4 6 8 10
3 6 9 12 15
4 8 12 16 20
5 10 15 20 25
*/

            for (int red = 1; red <= n; red++)
            {

                for (int korona = 1; korona <= n; korona++)
                {
                    Console.Write(red*korona);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            

            return;

                for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                if (i % 7 == 0)
                    Console.WriteLine();
            }
        }
    }
}
