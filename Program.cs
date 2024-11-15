using System;

namespace BlackJack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] cards = new string[4, 13]
            {
                { "As ♥,11", "2 ♥,2", "3 ♥,3", "4 ♥,4", "5 ♥,5", "6 ♥,6", "7 ♥,7", "8 ♥,8", "9 ♥,9", "10 ♥,10", "J ♥,10", "Q ♥,10", "K ♥,10" },
                { "As ♦,11", "2 ♦,2", "3 ♦,3", "4 ♦,4", "5 ♦,5", "6 ♦,6", "7 ♦,7", "8 ♦,8", "9 ♦,9", "10 ♦,10", "J ♦,10", "Q ♦,10", "K ♦,10" },
                { "As ♠,11", "2 ♠,2", "3 ♠,3", "4 ♠,4", "5 ♠,5", "6 ♠,6", "7 ♠,7", "8 ♠,8", "9 ♠,9", "10 ♠,10", "J ♠,10", "Q ♠,10", "K ♠,10" },
                { "As ♣,11", "2 ♣,2", "3 ♣,3", "4 ♣,4", "5 ♣,5", "6 ♣,6", "7 ♣,7", "8 ♣,8", "9 ♣,9", "10 ♣,10", "J ♣,10", "Q ♣,10", "K ♣,10" }
            };

            Random random = new Random();

            int playerValue = 0;
            int dealerValue = 0;

            
            dealerValue += ZieheKarte(cards, random, "Dealer");
            dealerValue += ZieheKarte(cards, random, "Dealer");


            while (dealerValue < 17)
            {
                dealerValue += ZieheKarte(cards, random, "Dealer");
            }

            Console.WriteLine($"Dealer hat einen Wert von: {dealerValue}");
            Console.WriteLine();


            playerValue += ZieheKarte(cards, random, "Spieler");
            playerValue += ZieheKarte(cards, random, "Spieler");


            while (true)
            {
                Console.WriteLine("Möchtest du noch eine Karte aufziehen? (j/n)");
                string eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "j")
                {
                    playerValue += ZieheKarte(cards, random, "Spieler");

                    if (playerValue > 21)
                    {
                        Console.WriteLine("Du hast dich überkauft! Dein Wert ist über 21.");
                        Console.WriteLine("Du hast verloren!");
                        return;
                    }
                }
                else if (eingabe.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte 'j' oder 'n' eingeben.");
                }
            }

            Console.WriteLine($"Dein Kartenwert ist: {playerValue}");


            if (playerValue > 21)
            {
                Console.WriteLine("Du hast dich überkauft! Du verlierst.");
            }
            else if (dealerValue > 21 || playerValue > dealerValue)
            {
                Console.WriteLine("Herzlichen Glückwunsch! Du hast gewonnen!");
            }
            else if (playerValue == dealerValue)
            {
                Console.WriteLine("Unentschieden! Niemand gewinnt.");
            }
            else
            {
                Console.WriteLine("Der Dealer hat gewonnen. Besseres Glück nächstes Mal!");
            }
        }

        static int ZieheKarte(string[,] cards, Random random, string spielerName)
        {
            int zeichen = random.Next(0, 4);
            int cardIndex = random.Next(0, 13);

            string gezogeneKarte = cards[zeichen, cardIndex];
            string[] cardParts = gezogeneKarte.Split(',');
            string cardName = cardParts[0];
            int cardValue = int.Parse(cardParts[1]);

            Console.WriteLine($"{spielerName} zieht: {cardName}, Wert: {cardValue}");
            return cardValue;
        }
    }
}