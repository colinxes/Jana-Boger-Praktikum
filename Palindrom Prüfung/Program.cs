using System.ComponentModel.Design; // C# oder C-Sharp

namespace Palindrom_Prüfung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfung auf Palindrome");
            Console.WriteLine("Gib etwas ein.");
            //Eingegebenes wird gemerkt.
            string eingegebenes
                = Console.ReadLine();
            //Umgekehrtes wird gemerkt.
            string umgekehrtes = "";
            for (int i = 0; i < eingegebenes.Length; i++)
            {
                umgekehrtes += eingegebenes[eingegebenes.Length - 1 - i];

               
            }
            //If-Else Anweisung
            if (eingegebenes.ToUpper().Replace(" ","") == umgekehrtes.ToUpper().Replace(" ", ""))
            {
                Console.WriteLine(eingegebenes + " ist ein Palindrom.");
            }
            else
            {
                Console.WriteLine($"{eingegebenes} ist kein Palindrom.");
            }
        }
    }
}