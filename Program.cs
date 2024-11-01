using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Baum", "Fluss", "Wüste", "Sonnenaufgang", "Regenbogen", "Felsen", "Dschungel", "Pinguin", "Elefant",
                "Krokodil",   "Libelle", "Ameise", "Eichhörnchen", "Albatros", "Koralle", "Seestern", "Tintenfisch", "Giraffe", "Architekt",
                "Mechaniker", "Ingenieur", "Journalist", "Lehrer", "Bäcker", "Anwalt", "Krankenpfleger", "Elektriker", "Künstler", 
                "Feuerwehrmann", "Pilot", "Gärtner", "Wissenschaftler", "Förster", "Designer", "Zahnarzt", "Pizza", "Nudel", 
                "Schokolade", "Eiscreme", "Avocado", "Karotte", "Limonade", "Käse", "Apfelkuchen", "Pfannkuchen", "Marmelade",
                "Joghurt", "Wassermelone", "Sandwich", "Paprika", "Keks", "Honig", "Gummibärchen", "Deutschland", "Italien",
                "Spanien", "Frankreich", "Kanada", "Ägypten", "Griechenland", "Norwegen", "Schweden", "China", "Brasilien",
                "Australien", "Marokko", "Venedig", "Madrid", "Sydney", "Rio de Janeiro", "Hamburg", "Mikroskop", "Teleskop",
                "Galaxie", "Elektrizität", "Roboter", "Computer", "Tablet", "Satellit", "Drohne", "Rakete", "Atome", "Algorithmus",
                "Speicherchip", "Internet", "Geometrie", "Energie", "Akku", "Software", "Gitarre", "Orchester", "Melodie", "Pinsel",
                "Symphonie", "Trompete", "Skulptur", "Oper", "Ballett", "Klavier", "Theater", "Leinwand", "Palette", "Note",
                "Dirigent", "Mosaik", "Collage", "Rhythmus", "Drache", "Zauberer", "Phönix", "Elfe", "Einhorn", "Kobold",
                "Talisman", "Fluch", "Feenstaub", "Magie", "Sirene", "Pegasus", "Riese", "Schwert", "Kristall", "Alchemist",
                "Hexenkessel", "Unsterblichkeit", "Regen", "Geburtstag", "Abenteuer", "Freundschaft", "Rätsel", "Mysterium",
                "Karussell", "Sternenhimmel", "Brücke", "Glücksbringer", "Kaktus", "Bücherregal", "Parfüm", "Überraschung",
                "Fernweh", "Herbstblätter", "Märchen"};

            int life = 9;
            int lifenow = life;   
            bool win = false;
         
            Random random = new Random();
            int randomword = random.Next(0, words.Length);
            string word = words[randomword];

            string striche = new string('-', word.Length);

           

            while(lifenow  > 0 && !win)
            {

                Console.WriteLine("Das Wort für das Hangman: " + striche );
            
              List<char> buchstbeversuch = new List<char>();



                Console.WriteLine("Errahten Sie einen Buchstaben: ");
                Console.WriteLine($"Du hasst noch {lifenow} leben");

                char guess = Convert.ToChar(Console.ReadLine());    
                
                if(word.Contains(guess) && !buchstbeversuch.Contains(guess))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    lifenow--;
                }
                buchstbeversuch.Add(guess);

                bool wordfertig = false;

                foreach(char c in word)
                    if(buchstbeversuch.Contains(c))
                        wordfertig = true;
                win = wordfertig;                                 
            }

            if(win)
            {
                Console.WriteLine("GLückwunsch, du hasst gewonnen!!");
            }
            else
                Console.WriteLine("Du hasst verloren:(");

















       


        }
    }
}
