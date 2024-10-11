namespace Primzahlen_Prüfung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Primzahlen_Prüfung");
                Console.WriteLine("Gib eine beliebige Zahl an.");

                string eingabe = Console.ReadLine();
                bool isInt = int.TryParse(eingabe, out int ein);
                if (isInt is false)
                {
                    Console.WriteLine($"\"{eingabe}\" ist kein Integer.");
                    continue;
                }

                bool istPrimzahl = PrimzahlenRechner.IstPrimzahl(ein);

                if (istPrimzahl)
                {
                    Console.WriteLine($"{ein} ist keine Primzahl.");
                }
                else
                {
                    Console.WriteLine($"{ein} ist eine Primzahl.");
                }
            }
        }
    }
}