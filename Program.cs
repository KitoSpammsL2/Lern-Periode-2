using System.ComponentModel.Design;

namespace RandomNuber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double grad; 

            while (true) 
            {
                Console.WriteLine("Was willst du für einen schwirigkeitsgrad?");
                Console.WriteLine("Leicht(1) = Zahl: 1-100  Versuche: 10");
                Console.WriteLine("Normal(2) = Zahl: 1-500  Versuche: 10");
                Console.WriteLine("Schwer(3) = Zahl: 1-1000 Versuche: 10");
                string eingabe = Console.ReadLine();


                if (Double.TryParse(eingabe, out grad) && (grad == 1.0 || grad == 2.0 || grad == 3.0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                }
            }
           
            string guess;
            int input;

            if (grad == 1)
            {
                Random random = new Random();
                int glückszahl = random.Next(1, 100);
 
                while (true)
                {

                    while (true)
                    {
                        Console.Write("Raten Sie von 1-100: ");
                        guess = Console.ReadLine();
                        input = Convert.ToInt32(guess);

                        if (input <= 100 && input >= 1 )
                        {
                            break;
                            
                        }
                        else  
                        {
                            Console.WriteLine("Ungültige Eingabe");

                        }
                      
                    }
                                   
                    if (glückszahl < input)
                    {
                        Console.WriteLine("Deine Zahl ist zu gross!");

                    }

                    if (glückszahl == input)
                    {
                        Console.WriteLine("Du hasst gewonnen");
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Deine Zahl ist zu klein");
                    }
                }    
            }
              
            if (grad == 2)
            {
                Random random = new Random();
                int glückszahl = random.Next(1, 500);
              

                while (true)
                {

                    while (true)
                    {
                        Console.Write("Raten Sie von 1-100: ");
                        guess = Console.ReadLine();
                        input = Convert.ToInt32(guess);
                        if (input <= 500 && input >= 1)
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe");

                        }

                    }

                    if (glückszahl < input)
                    {
                        Console.WriteLine("Deine Zahl ist zu gross!");

                    }

                    if (glückszahl == input)
                    {
                        Console.WriteLine("Du hasst gewonnen");
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Deine Zahl ist zu klein");
                    }
                }
            }
            
            if (grad == 3)
            {
                Random random = new Random();
                int glückszahl = random.Next(1, 1000);
              

                while (true)
                {

                    while (true)
                    {
                        Console.Write("Raten Sie von 1-100: ");
                        guess = Console.ReadLine();
                        input = Convert.ToInt32(guess);
                        if (input <= 1000 && input >= 1)
                        {
                            break;

                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe");

                        }

                    }

                    if (glückszahl < input)
                    {
                        Console.WriteLine("Deine Zahl ist zu gross!");

                    }

                    if (glückszahl == input)
                    {
                        Console.WriteLine("Du hasst gewonnen");
                        break;
                    }


                    else
                    {
                        Console.WriteLine("Deine Zahl ist zu klein");
                    }
                }
            }       
 //  > <
        }
    }
}
