using System;

namespace console { 
internal class Program
{
    static int n = 0;
    static int[] tab;
    static Random los = new Random();

    static void RobTablice()
    {
        Console.Write("Podaj rozmiar tablicy nie mniejszy niż 50, n=");
        n = int.Parse(Console.ReadLine());
        tab = new int[n + 1];
        for (int i = 0; i < n; i++)
            tab[i] = los.Next(100) + 1;
    }
    static int Szukaj(int szukana)
    {
        tab[n] = szukana;
        for (int i = 0; i < n + 1; i++)
            if (tab[i] == szukana) return i;
        return n;
    }
    static void PokazTablice_i_Wynik_Szukania(int x, int id)
    {
        for (int i = 0; i < n + 1; i++)
            Console.Write(String.Format("{0},", tab[i]));
        if (id != n)
            Console.WriteLine(String.Format("\nSzukana liczba {0} jest na indeksie {1}", x, id));
        else
            Console.WriteLine(String.Format("\nSzukana liczba {0} nie została znaleziona. Znaleziono wartownika na indeksie {1}", x, id));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Witaj w CzD! Wyszukiwanie z wartownikiem. Egzamin INF.04 czerwiec 2022");
        RobTablice();
        Console.Write("Podaj szukaną liczbę całkowitą x = ");
        int x = int.Parse(Console.ReadLine());
        int id = Szukaj(x);
        PokazTablice_i_Wynik_Szukania(x, id);
        Console.ReadKey();
    }
}
}