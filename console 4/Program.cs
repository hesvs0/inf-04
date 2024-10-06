using System;

namespace console_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notatka notatka_1,notatka_2,notatka_3;
            notatka_1 = new Notatka("Informacja dnia","UWAGA! W dniu dzisiejszym rozpoczynają się egzaminy");
            notatka_2 = new Notatka("Egzamin trwa", "Uczniowie 4 klasy technikum o kierunku technik programista");
            notatka_3 = new Notatka("Wyniki egzaminu", "W najblizszych dniach CKE opublikuje wyniki egzaminu");
            Console.WriteLine("Pokaż NOTATKI");
            notatka_1.PokazNotatke();
            notatka_2.PokazNotatke();
            notatka_3.PokazNotatke();
            Console.WriteLine("Pokaż DIAGNOSTYKĘ");
            notatka_1.Diagnostyka();
            notatka_2.Diagnostyka();
            notatka_3.Diagnostyka();
            Console.ReadKey();
        }
    }
}
