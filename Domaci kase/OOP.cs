using System;

namespace oopvezbe
{
    class Brojac
    {
        public int broj = 0;

        public int Broj()
        {
            return broj;
        }

        public void Povecaj()
        {
            broj++;
        }
    }

    class Kvadrat
    {
        public int duzinaStranice = 1;

        public int Povrsina()
        {
            return duzinaStranice * duzinaStranice;
        }

        public int Obim()
        {
            return duzinaStranice * 4;
        }

        public double Dijagonala()
        {
            return duzinaStranice * Math.Sqrt(2.0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             ---------------------------------------------------
             | a   | b   | ...   || duzinaStranice (int) = 1  ||
             ---------------------------------------------------
            */
            
            Kvadrat k = new Kvadrat() { duzinaStranice = 5 };
            Console.WriteLine(k.Povrsina()); // 25
            Console.WriteLine(k.Obim()); // 20
            Console.WriteLine(k.Dijagonala());

            for(int i = 0; i < 100; i++)
            {
                Krug c = new Krug() { poluprecnik = i };
                Console.WriteLine(c.Povrsina());
                Console.WriteLine(c.Obim());
            }

        }
    }

    public class Krug
    {
        public int poluprecnik;

        public double Povrsina()
        {
            // r^2 PI
            return this.poluprecnik * this.poluprecnik * Math.PI;
        }

        public double Obim()
        {
            // 2r PI
            return 2 * this.poluprecnik * Math.PI;
        }
    }
}

/*            Brojac peraZdera = new Brojac();
            Console.WriteLine(peraZdera.Broj());
            peraZdera.Povecaj();
            Console.WriteLine(peraZdera.Broj());*/
