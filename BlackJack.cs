using System;

namespace BlackJack
{
    internal class BlackJack
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

            int playerValue = 0;
            int dealerValue = 0;

            int Geld = 1000;
            char jn;

            for (int i = 0; i < 2; i++)
            {
                Random random = new Random();
                int zeichen = random.Next(0, 4);
                int cardIndex = random.Next(0, 13);


                string gezogeneKarte = cards[zeichen, cardIndex];
                string[] cardParts = gezogeneKarte.Split(',');
                string cardName = cardParts[0];
                int cardValue = int.Parse(cardParts[1]);

                Console.WriteLine($"Dealer Karte: {cardName} ");
                dealerValue = dealerValue + cardValue;
            }
            Console.WriteLine($"Dealer hat einen Wert von: {dealerValue} ");
            Console.WriteLine(" ");


                for (int i = 0; i < 2; i++)
            {
            Random random = new Random();
            int zeichen = random.Next(0, 4);   
            int cardIndex = random.Next(0, 13);  

            
            string gezogeneKarte = cards[zeichen, cardIndex];
            string[] cardParts = gezogeneKarte.Split(',');
            string cardName = cardParts[0];
            int cardValue = int.Parse(cardParts[1]);

            Console.WriteLine($"Gezogene Karte: {cardName}, Wert: {cardValue}");
                playerValue = playerValue + cardValue;
            if (i > 0 )
                {                   
                    while (true)
                    {
                        Console.WriteLine("Möchtest du noch eine Karte aufziehen? (j/n)");
                        string eingabe2 = Console.ReadLine();

                        if (char.TryParse(eingabe2, out jn) && (jn == 'j' || jn == 'n' ))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen gültigen Operator ein");
                        }
                    }

                    switch (jn)
                    {
                        case 'j':
                            {
                                Random random1 = new Random();
                                int zeichen1 = random.Next(0, 4);
                                int cardIndex1 = random.Next(0, 13);


                                string gezogeneKarte1 = cards[zeichen, cardIndex];
                                string[] cardParts1 = gezogeneKarte.Split(',');
                                string cardName1 = cardParts[0];
                                int cardValue1 = int.Parse(cardParts[1]);

                                Console.WriteLine($"Gezogene Karte: {cardName1}, Wert: {cardValue1}");
                                playerValue = playerValue + cardValue1;




                                break;
                            }
                        case 'n': 
                            {  
                                break;
                            }  
                    }


                }                 

            }
            Console.WriteLine($"Dein Wert aus der Karten sind: {playerValue}");  
        }
    }
}
