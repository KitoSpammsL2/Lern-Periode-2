using System;
using System.Collections.Generic;

namespace BlackJack1
{
    internal class programm
    {
        static void Main(string[] args)
        {         
            List<string> deck = new List<string>
            {
                "As ♥,11", "2 ♥,2", "3 ♥,3", "4 ♥,4", "5 ♥,5", "6 ♥,6", "7 ♥,7", "8 ♥,8", "9 ♥,9", "10 ♥,10", "J ♥,10", "Q ♥,10", "K ♥,10",
                "As ♦,11", "2 ♦,2", "3 ♦,3", "4 ♦,4", "5 ♦,5", "6 ♦,6", "7 ♦,7", "8 ♦,8", "9 ♦,9", "10 ♦,10", "J ♦,10", "Q ♦,10", "K ♦,10",
                "As ♠,11", "2 ♠,2", "3 ♠,3", "4 ♠,4", "5 ♠,5", "6 ♠,6", "7 ♠,7", "8 ♠,8", "9 ♠,9", "10 ♠,10", "J ♠,10", "Q ♠,10", "K ♠,10",
                "As ♣,11", "2 ♣,2", "3 ♣,3", "4 ♣,4", "5 ♣,5", "6 ♣,6", "7 ♣,7", "8 ♣,8", "9 ♣,9", "10 ♣,10", "J ♣,10", "Q ♣,10", "K ♣,10"
            };

            Random random = new Random();
            double cash = 1000;
            double bet = 0;

            while (cash > 0)
            {
               
                Mischen(deck, random);

                int playerValue = 0;
                int dealerValue = 0;
               
                Console.WriteLine($"Dein Kapital beträgt {cash} CHF.");
                Console.WriteLine("Wie viel möchtest du setzen?");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out bet) && bet > 0 && bet <= cash)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib einen gültigen Betrag ein.");
                    }
                }
    
                dealerValue += ZieheKarte(deck, random, "Dealer");
                dealerValue += ZieheKarte(deck, random, "Dealer");
                
                playerValue += ZieheKarte(deck, random, "Spieler");
                playerValue += ZieheKarte(deck, random, "Spieler");
               
                while (true)
                {
                    Console.WriteLine("Möchtest du noch eine Karte ziehen? (j/n)");
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "j")
                    {
                        playerValue += ZieheKarte(deck, random, "Spieler");

                        if (playerValue > 21)
                        {
                            Console.WriteLine("Du hast dich überkauft! Dein Wert ist über 21.");
                            cash -= bet; // Verlust
                            break;
                        }
                    }
                    else if (choice.ToLower() == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte 'j' oder 'n' eingeben.");
                    }
                }

                
                while (dealerValue < 17)
                {
                    dealerValue += ZieheKarte(deck, random, "Dealer");
                }

             
                Console.WriteLine($"Dein Kartenwert: {playerValue}, Dealer-Wert: {dealerValue}");
                if (playerValue > 21 || (dealerValue <= 21 && dealerValue >= playerValue))
                {
                    Console.WriteLine("Du verlierst!");
                    cash -= bet;
                }
                else
                {
                    Console.WriteLine("Du gewinnst!");
                    cash += bet;
                }

                Console.WriteLine($"Neues Guthaben: {cash} CHF");

                if (cash <= 0)
                {
                    Console.WriteLine("Du hast kein Kapital mehr. Spiel beendet!");
                    break;
                }

                Console.WriteLine("Möchtest du eine weitere Runde spielen? (j/n)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() != "j")
                {
                    Console.WriteLine("Spiel beendet. Vielen Dank fürs Spielen!");
                    break;
                }
            }
        }

        static int ZieheKarte(List<string> deck, Random random, string spielerName)
        {
            if (deck.Count == 0)
            {
                Console.WriteLine("Keine Karten mehr im Deck. Deck wird neu gemischt.");
                return 0;
            }

            string gezogeneKarte = deck[random.Next(deck.Count)];
            deck.Remove(gezogeneKarte);

            string[] cardParts = gezogeneKarte.Split(',');
            string cardName = cardParts[0];
            int cardValue = int.Parse(cardParts[1]);

            Console.WriteLine($"{spielerName} zieht: {cardName}, Wert: {cardValue}");
            return cardValue;
        }

        static void Mischen(List<string> deck, Random random)
        {
            for (int i = 0; i < deck.Count; i++)
            {
                int j = random.Next(deck.Count);
                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}
