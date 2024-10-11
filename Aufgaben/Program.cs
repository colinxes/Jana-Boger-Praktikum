namespace Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ausgabe
            Console.Write("Bitte gib etwas ein: ");

            // Auslesen
            var input = Console.ReadLine();

            // Variablen
            string aText;
            int number1 = 10;
            int number2 = 20;
            double numberWithComma = 44324.111;
            bool trueOrFalse = false;
            List<int> texts = new List<int>();

            // If-Anweisung
            if (true)
            {
                Console.WriteLine("Nummer 1 ist größer als Nummer 2.");
            }

            // If-Else Anweisung
            if (number1 >= number2)
            {
                Console.WriteLine("Nummer 1 ist größer als Nummer 2.");
            }
            else
            {
                Console.WriteLine("Nummer 2 ist größer als Nummer 1.");
            }

            // If-Else-If Anweisung
            if (number1 >= number2)
            {
                Console.WriteLine("Nummer 1 ist größer als Nummer 2.");
            }
            else if (number1 <= number2)
            {
                Console.WriteLine("Nummer 2 ist größer als Nummer 1.");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
            }

            // Schleifen

            for (int i = 0; i < number1; i++)
            {

            }

            string umgekehrtes = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                umgekehrtes += input[input.Length - 1 - i];
            }

            while (true)
            {

            }

            foreach (char value in input)
            {
                umgekehrtes += value;
            }


            Console.ReadKey();
        }
    }
}