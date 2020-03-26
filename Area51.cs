using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Web;
using System.Threading;

namespace Vezbe
{
    public class Area51
    {
        string data = "MMMMMMMMMMMMMMMMWNOdllllooollldOXWMMMMMMMMMMMMMMMM%0D%0AMMMMMMMMWMMMMWXkxxxk0KXNWWNNK0kxxdkXWMMWWMMMMMMMMM%0D%0AMMMMMMMMMWWXkoox0NMMMMMMMMMMWWMMW0xooxKWMMMMMMMMMM%0D%0AMMMMMMMWXxlcoONMMMMMMMMMMMMWNNWMMMWNOl%3Bcd0WMWWMMMM%0D%0AMMMMMW0ol%3BlKWMMMMMMMMMMMMMMMMWWMMMMMMW0l%3BcdONWMMMM%0D%0AMMMWOooOKXWWMMMMMMMMMMMMMMMMMMMMMMMMMMMWXKOolOWMMM%0D%0AMMNdcxNWNMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNkcdXMM%0D%0AMXolKN0ONMMMWMMMMMMMMMMMMMMMMMMMMMMMMMMMMXk0WKllKM%0D%0AXllKMKxKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKdOWXllX%0D%0Ax%3AOWWkkWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWkxWM0%3Ad%0D%0AcdWMNxOMMMMWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMWWOxXMWd%3A%0D%0A%3BOMMNxOMMWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0kNMMO%3B%0D%0A%3BOWMMOkNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWO0MMWO%2C%0D%0A%2CdXWMNO0MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK0NMWKd%3B%0D%0A%3BckXMMXKNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMN0XMMKkc%3B%0D%0Al%3BlkNMMWNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNNMMNkl%3Bc%0D%0AO%3B%3BxNMMWNNNNNNWMMMMMMMMMMMMMMMMMMMWWNNNNNWWMWNx%3B%3Bk%0D%0A0cxNWX0kkkO0XXNNNWWWWMMMMMMMMWWWWWXXNNK0OOO0KWWxcO%0D%0AcdNMWk%2C..%27%2C%3Bcok0NWNNXNWMMWMWNXXWMNKkdl%3A%2C%27%27.%2CkWMWxc%0D%0Acc0NXo%27........%27%3AdKNNXKXMMNKXNWKd%3A%27........%27oXN0lc%0D%0AKd%3Alkc%27...........%27lKW0OKXO0WKo%2C...........%27cko%3AxX%0D%0AWNo%3Axo%3B%2C..........%27%2C%3BookXXkoo%3B............%27%3Box%3AoNM%0D%0AWWO%3Ao0d%3B%27........%2C%3B%3A%2C%27dXWWNd%2C%2C%3B%27..........%3Bd0d%3BkMM%0D%0AMMkl0MNKxc%3B%2C%27%27%2C%3B%3AllloOWWWMMNOoool%3A%3B%2C%27%27%27%2CcxKWWKlxMM%0D%0AMMx%3Ax0KNWWX000KKXK0KWMMMMWWWWNXKXXKK00KXNMWKKOcxWM%0D%0AMMNxcc%3BckNMWWMMMN00XX0KWMMWKOKN00NWWMMWWN0oclokNMM%0D%0AMMWWNXOl%2C%3AkXMMMXxkNWXo%3AkWWO%3AoXWNOxKMWMXk%3A%2Co0XNWMMM%0D%0AMMMMWMMNl.%27%3Adxd%3AdNMWWWXXWWXKWMMMWd%3Adxd%3A..cXMMMMMMM%0D%0AMMMMMMMMO%2C%2Clxko%3BkMWMMMMNKKNMMMMMMk%3Bokxo%2C%2COWMMMMMMM%0D%0AMMMMMMMMNo%3AONWNxkWMMMMWXOkKMWMMMWkxNWNO%3AlNMMMMMMMM%0D%0AMMMMMMMMMKcoXMMK0NWNK000OOOO0KXWNOKMWNocKMMMMMMMMM%0D%0AMMMMMMMMMWKddxOXWWWNXXXOooOXXXXWWWNOxddXMMMMWMMMMM%0D%0AMMMMMMMMMMWWXOoo0WMMWNXkdokKXWMMWKolkXWMMMMWNWWMMM%0D%0AMMMMMMMMMMMMMMWOokNWWWWWWWWWNWMWOoOWMMMMMMMMMMMMMM%0D%0AMMMMMMMMMMMMMMMMXxxOO0NWWWWNKOOxdKMMMMMMMMMMMMMMMM%0D%0AMMWWWMMMWWMWWMMWWWKkl%3A%3Aclclc%3AlkKWWWWWWWWMMWMMMMMMM";

        public void Test()
        {
            string[] byLines = HttpUtility.UrlDecode(data).Split('\n');

            int charCount = 0;

            foreach (var line in byLines)
            {
                charCount += line.Length;
            }

            Random r = new Random(55);

            int a, b;

            char[] obfus = new char[5] { '#', '@', '$', '%', '&' };

            foreach (var line in byLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (r.Next(0, 100) > 51)
                    {
                        // certainly true
                        do
                        {
                            a = r.Next(0, 50);
                            b = r.Next(0, 50);
                        } while (!Hypothesis(a, b));
                    }
                    else
                    {
                        // probably false
                        a = r.Next(0, 50);
                        b = r.Next(0, 50);
                    }

                    if(Rozvel.Jr234f9w0ef(a, b)
                        == Hypothesis(a, b))
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(line[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(obfus[r.Next(0, 5)]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public bool Hypothesis(int a, int b)
        {
            int c = a * b;
            return (a == 0
                 || b == 0
                 || c == 0
                 || a == 24
                 || b == 24
                 || c == 24);
        }
    }
}
