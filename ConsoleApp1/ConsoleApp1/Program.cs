using System;

class Program
{
    static char SprawdzPlec(string pesel)
    {
        int dziesiataCyfra = int.Parse(pesel[9].ToString());

        if (dziesiataCyfra % 2 == 0)
        {
            return 'K'; 
        }
        else
        {
            return 'M'; 
        }
    }
    static bool SprawdzSumeKontrolna(string pesel)
    {
        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int suma = 0;

        for (int i = 0; i < 10; i++)
        {
            suma += int.Parse(pesel[i].ToString()) * wagi[i];
        }

        int kontrolna = (10 - (suma % 10)) % 10;

        return kontrolna == int.Parse(pesel[10].ToString());
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer PESEL:");
        string pesel = Console.ReadLine();

        if (pesel.Length != 11)
        {
            Console.WriteLine("Numer PESEL musi składać się z 11 cyfr.");
            return;
        }

        char plec = SprawdzPlec(pesel);
        if (plec == 'K')
        {
            Console.WriteLine("Płeć: Kobieta");
        }
        else
        {
            Console.WriteLine("Płeć: Mężczyzna");
        }


        if (SprawdzSumeKontrolna(pesel))
        {
            Console.WriteLine("Numer PESEL jest poprawny.");
        }
        else
        {
            Console.WriteLine("Numer PESEL jest niepoprawny.");
        }
    }
}
