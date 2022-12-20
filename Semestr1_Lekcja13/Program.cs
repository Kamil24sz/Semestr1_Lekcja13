using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WypiszTekst();

            string[] wynik = Gry();
           foreach (string gra in wynik)
                Console.WriteLine(gra);

            Console.ReadLine();
        }

        //metoda która nic nie pobiera i nic nie zwraca tylko wypisuje "dowolny tekst"
        public static void WypiszTekst() {
            Console.WriteLine("Dowolny Tekst");
        }
        //metoda która nic nie pobiera i zwraca tablicę napisów z tytułami gier komputerowych
        public static string[] Gry() {
            return new string[] {"Minecraft", "Word of thanks", "Call of Duty"};
        }
    }
}
