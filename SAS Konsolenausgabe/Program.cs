using System;
using System.Threading;


class Program
{

    public static void Main(string[] args)
    {
        Aufgabe1(); // <-- Funktion für Aufgabe 1
        Aufgabe2(); // <-- Funktion für Aufgabe 2
        Aufgabe3(); // <-- Funktion für Aufgabe 3

    }

    static void Aufgabe1()
    {
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine("Aufgabe 1.\n");
        Thread.Sleep(1000);
        Console.WriteLine("");
        string[] myArray = { " .-.", "(o o)", "| 0 |", "|   |", "'~~~'\n" };
        foreach (string Wort in myArray)
        {
            Console.WriteLine(Wort);
        }
        Console.WriteLine("------------------------------------------");
        Thread.Sleep(2000);
        return;
    }


    static void Aufgabe2()
    {
        Console.WriteLine("Aufgabe 2\n");
        Thread.Sleep(1000);
        string Vorname = "Berkay";
        string Nachname = "Ismail";
        string Alter = "17";
        Console.WriteLine($"Vorname: {Vorname}\nNachname: {Nachname}\nAlter: {Alter} Jahr alt\n");
        Console.WriteLine("------------------------------------------");
        Thread.Sleep(2000);
        return;
    }

    static void Aufgabe3()
    {
        Console.WriteLine("Aufgabe 3\nBitte geben Sie die folgenden Aussagen ein.\n");
        Thread.Sleep(1000);
        Console.WriteLine("Vorname:");
        string Vorname = Console.ReadLine();
        Console.WriteLine("\nAlter:");
        string Alter = Console.ReadLine();
        Console.WriteLine("\nKlasse:");
        string Klasse = Console.ReadLine();
        Console.WriteLine($"\n{Vorname} ist {Alter} Jahre alt und besucht die {Klasse} des Georg-Simon-Ohm Berufskollegs.\n");
        Console.WriteLine("------------------------------------------");
        Thread.Sleep(2000);
        return;
    }
}