namespace Hangman2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbole = { "1", "2", "3", "4", "5" };
            Random zufall = new Random();
            int guthaben = 100;

            Console.WriteLine("Willkommen beim Einarmigen Banditen!");

            while (guthaben > 0)
            {
                Console.WriteLine($"\nGuthaben: {guthaben}");

                int einsatz = 0;
                while (einsatz <= 0 || einsatz > guthaben)
                {
                    Console.Write($"Einsatz (1 bis {guthaben}): ");
                    string eingabe = Console.ReadLine();
                    if (!int.TryParse(eingabe, out einsatz) || einsatz <= 0 || einsatz > guthaben)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl im gültigen Bereich ein.");
                        einsatz = 0;
                    }
                }

                string walze1 = symbole[zufall.Next(symbole.Length)];
                string walze2 = symbole[zufall.Next(symbole.Length)];
                string walze3 = symbole[zufall.Next(symbole.Length)];

                Console.WriteLine($"\n| {walze1} | {walze2} | {walze3} |");

                int gewinn = BerechneGewinn(walze1, walze2, walze3, einsatz);
                if (gewinn > 0)
                {
                    Console.WriteLine($"Gewinn: {gewinn}");
                    guthaben += gewinn;
                }
                else
                {
                    Console.WriteLine("Verloren!");
                    guthaben -= einsatz;
                }

                Console.Write("Weiter? (j/n): ");
                if (Console.ReadLine().ToLower() != "j") break;
            }

            Console.WriteLine("Spiel beendet. Danke fürs Spielen!");
        }

        static int BerechneGewinn(string walze1, string walze2, string walze3, int einsatz)
        {
            if (walze1 == walze2 && walze2 == walze3) 
            {
                return einsatz * int.Parse(walze1) * 10;
            }
            else if (walze1 == walze2 || walze2 == walze3 || walze1 == walze3) 
            {
                string gleichesSymbol = walze1 == walze2 ? walze1 : (walze2 == walze3 ? walze2 : walze1);
                return einsatz * int.Parse(gleichesSymbol) * 2;
            }
            else
            {
                return 0; 
            }
        }
    }
}
