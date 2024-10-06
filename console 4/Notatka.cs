using System;

namespace console_4
{
    internal class Notatka
    {
        private static int licznik=0;
        private int id;
        public string tytul;
        public string tresc;

        public Notatka(string _tytul,string _tresc) {
            licznik++;
            id = licznik;
            tytul = _tytul;
            tresc = _tresc;
        }
        public void Diagnostyka()
        {
            Console.WriteLine(String.Format(
                              "Licznik: {0}, id: {1}, Tytuł: {2}, Treść: {3}",
                              licznik,id,tytul,tresc));
        }
        public void PokazNotatke()
        {
            Console.WriteLine(String.Format(
                              "Tytuł: {0}\n\tTreść: {1}",
                              tytul, tresc));
        }
    }
}
