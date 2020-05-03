using System;

namespace Domaci_kase
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Zdenka", "Sir",
                new Adresa("Zvonka Bogdana", 7),
                new Datum(17, 5, 2002));
            Console.WriteLine($"Zovem se {s}");
        }
        
    }
    class Student
    {
        public string Ime { get; private set; }
        private string prezime;
        private Adresa adresa;
        private Datum datum;

        public override string ToString()
        {
            return $"{this.Ime} {this.prezime}";
        }
        public Student(string ime, string prezime, Adresa adresa, Datum datum)
        {
            this.Ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.datum = datum;
        }
    }
    class Adresa
    {
        private string uica;
        private int broj;

        public Adresa(string uica, int broj)
        {
            this.uica = uica;
            this.broj = broj;
        }
    }
    class Datum
    {
        private int dan, mesec, godina;

        public Datum(int dan, int mesec, int godina)
        {
            this.dan = dan;
            this.mesec = mesec;
            this.godina = godina;
        }
    }
}
