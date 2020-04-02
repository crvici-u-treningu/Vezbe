using System;
using System.Collections.Generic;
using System.Text;

namespace Vezbe
{
    public class NajduzaRec
    {
        // Zadatak: vrati duzinu najduze reci u recenici, bez znakova
        // interpunkcije.

        // hint: ne postoji metoda koja ce vratiti reci iz recenice,
        // morate brojati slovo po slovo i pamtiti negde duzinu i 
        // tako to, porediti ih, itd. snalazljivost!
        // najvaznija je postavka, potrudite se, gurajte koliko mozete
        // i cesto stanite da vidite sta program radi/ne radi.

        // primeri:

        /*
           +--------- recenica -----------+------- najduza rec ---------------+-- duzina --+
           | ovo ovde je najduza rec      | "najduza"                         |     7      |
           +------------------------------+-----------------------------------+------------+
           | tri pet sest sedam           | "sedam"                           |     5      |
           +------------------------------+-----------------------------------+------------+
           | tacke se ne broje.           | "tacke" (ili "broje", koje god)   |  5 (ne 6!) |
           +------------------------------+-----------------------------------+------------+
            
            bonus imaginarni bodovi: zarezi se takodje ne broje ;)
        */

        // pomoc prijatelja:
        // da biste ispitale da li je na nekom mestu (recimo 3) 
        // u stringu (recimo X) neko slovo (recimo tacka), radite to ovako:
        
        /*
             // posebna paznja na ove navodnike
             // ovo su navodnici samo za karaktere
             //        |
             //        v
           if(X[3] == '.') { ... }
             (NE ovo: `.`)

        */

        // inace se koriste obicni dupli navodnici za stringove van toga. Dakle, bice
        // "ovo je recenica" ali 'o' je prvo slovo. Razlika je jos uvek jako teska za
        // objasnjavanje ali vremenom cemo doci do toga. Zasad je bitno da mozete da
        // baratate sa tim :)

        /*
         
            dakle, ako poredimo stringove: if(rec == "mozda") { ... }
            ali ako poredimo slova u reci: if(rec[0] == 'm') { ... }

            btw, Biljo, 7of9 ima devojku u Picardu :3
         */

        public static int NadjiDuzinuNajduzeReciU(string recenica)
        {
            int max = 0;
            int i = 0;
            int brojacSlova = 0;
            
            while (i < recenica.Length)
            {
                if (recenica[i] == ' ')
                {
                    brojacSlova++;
                    i++;
                }
                i++;
            }
            return max;
        }
    }
}
