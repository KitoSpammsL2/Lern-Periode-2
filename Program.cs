namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            {
                string[] symbols = { "1", "2", "3", "4", "5" };
                Random random = new Random();
                bool spielen = true;

                Console.WriteLine("Willkommen beim Einarmigen Banditen!");

                while (spielen)
                {
                    
                    string reel1 = symbols[random.Next(symbols.Length)];
                    string reel2 = symbols[random.Next(symbols.Length)];
                    string reel3 = symbols[random.Next(symbols.Length)];

                    
                    Console.WriteLine($"| {reel1} | {reel2} | {reel3} |");

                    
                    if (reel1 == reel2 && reel2 == reel3)
                    {
                        Console.WriteLine("Jackpot! Du hast gewonnen!");
                    }
                    else
                    {
                        Console.WriteLine("Leider verloren. Versuch's noch einmal!");
                    }

                   
                    Console.Write("Noch einmal spielen? (j/n): ");
                    string input = Console.ReadLine();
                    spielen = input.ToLower() == "j";
                }

                Console.WriteLine("Danke fürs Spielen!");
            }
        }

    }
}

