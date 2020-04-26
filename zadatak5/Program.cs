using System;

namespace zadatak5
{
    class Program
    {
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void uMain(string[] args)
        {
            int a = 3;
            int b = 5;
            a = a + b;
            b = a - b;
            a = a - b;
       
            Console.WriteLine(a);

            Console.WriteLine(b);
        }
        static void sMain(string[] args)
        {
            long a = 0;
            long b = 1;
            long zbir = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(zbir);

            for (int i = 0; i <= 100; i++)
            {
                a = b;
                b = zbir;
                zbir = a + b;
                Console.WriteLine(zbir);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(4));
        }
           
        static int Fib(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            int a = 0;
            int b = 1;
            int zbir = a + b;
            for (int i = 0; i < n-3; i++)
            {
                a = b;
                b = zbir;
                zbir = a + b;
            }
            return zbir;
        }
    }
}
