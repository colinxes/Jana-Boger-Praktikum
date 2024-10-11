using Primzahlen_Prüfung;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Primzahl_Auflistung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prmzahl Auflistung");
            Console.WriteLine("Gib eine beliebige Zahl an.");
            string eingabe = Console.ReadLine();
            bool isInt = int.TryParse(eingabe, out int Zahl);
            if (isInt is false)
            {
                Console.WriteLine($"\"{eingabe}\"ist kein Integer.");
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("2 ist eine Primzahl.");
            for (int ein = 3; ein <= Zahl; ein += 2) // n = n + 1 | n += 1 | n++
            {
                bool istPrimzahl = PrimzahlenRechner.IstPrimzahl(ein);
                if (istPrimzahl == true)
                {
                    Console.WriteLine($"{ein} ist eine Primzahl.");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"\n\nZeit: {stopwatch.ElapsedMilliseconds} ms");

            int Ergebnis = 6 / 2; // Ergbnis = 3

            int result = 14 % 2; // Ergebnis = 0
            int result2 = 13 % 2; // Ergebnis = 1
            int result3 = 13 % 5; // Ergebnis = 3
        }
    }
}