using System;

namespace Zadatak1
{
    class Program
    {
        static void Format(int n)
        {
         //   int n = RandomInt.GetNew(1, 100);
            
            Console.Write(n);

            if (1<=n && n<=9)
            {
                Console.Write("  ");  
            }
            else if (10 <= n && n <= 99)
            {
                Console.Write(" ");
            }
        }

        static void Kaendar(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Format(i);
                Console.Write(" ");
                if (i % 7 == 0)
                    Console.WriteLine();
            }

        }
        static void TabMnozenja(int n)
        {
            for (int red = 1; red <= n; red++)
            {

                for (int korona = 1; korona <= n; korona++)
                {
                    Format(red * korona);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static void Pravougaonik (int a, int b)
        {
            for (int red = 1; red <= a; red++)
            {

                for (int korona = 1; korona <= b; korona++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        static void aMain(string[] args)
        {
            Console.Write("daj mi jedan broj: ");
            int n = Read.Int();
            Console.Write("daj mi drugi broj: ");
            int m = Read.Int();
            Console.WriteLine("*");

            for (int red = 1; red <= n; red++)
            {

                for (int korona = 1; korona <= m; korona++)
                {
                    //Format(red * korona);
                    if (red == 1 || red == n || korona == 1 || korona == m)
                        Console.Write("*");
                    else Console.Write(" ");

                }

                Console.WriteLine();
            }


            /*n = 5
1 2 3 4 5
2 4 6 8 10
3 6 9 12 15
4 8 12 16 20
5 10 15 20 25
*/
            //Kaendar(n);
            Console.WriteLine();
            //TabMnozenja(n);
            //Pravougaonik(n, m);

            




        }
    }
}
