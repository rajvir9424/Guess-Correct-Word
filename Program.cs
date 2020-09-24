using System;
using System.Runtime.CompilerServices;

namespace CorrectWord
{
    class Program
    {
        static string correctword;
        static char[] letters;
        static Player player;
        static string clue;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game ");

            Startgame();
            Playgame();
            Endgame();
            
        }

        static void Startgame()
        {
            string[] cricketers;


            cricketers = new string[] { "dhoni", "sachin", "virat","sehwag"};

            


            Random random = new Random();
            correctword = cricketers[random.Next(0, cricketers.Length)];
            Askusername();
            letters = new char[correctword.Length];
            for (int i = 0; i < correctword.Length; i++)

                letters[i] = '-';

           

            Console.Write(letters);
            Console.WriteLine();


        }

        static void Askusername()
        {
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();
            if (input.Length >= 2)
            {
                player = new Player(input);

               
            }


            else
            {
                Console.WriteLine("Please enter a valid user name");
                Askusername();
            }






        }




        static void Playgame()
        {
            do
            {
                Console.Clear();
                displaymaskedword();
                Console.WriteLine();
                char guessedletter = Askforletter();
                CheckedLetters(guessedletter);


            } while (correctword != new string(letters));

            Console.Clear();
        }

        private static void CheckedLetters(char guessedletter)
        {
            for (int i = 0; i < correctword.Length; i++)
            {
                if (guessedletter == correctword[i])
                {
                    letters[i] = guessedletter;

                    player.Score++;

                }
            }
        }

        static char Askforletter()
        {

            string input;

            do
            {
                Console.WriteLine("Enter a letter");
                

                
                
                    if (correctword == "dhoni")
                    {
                        Console.WriteLine("He has won it all, stress never gets to him");
                    }
                     
                    if (correctword== "virat")
                    {
                        Console.WriteLine("Flamboyant and stylish player, agrresive in nature");
                    }

                    if (correctword== "sachin")
                    {
                        Console.WriteLine("Greatest batsman ever seen in the history of cricket, played shots with perfection");
                    }
                    if (correctword== "sehwag")
                {
                    Console.WriteLine("Ruthless attacker, had his own style of play");
                }




                
                input = Console.ReadLine();


            } while (input.Length != 1);

            var lettersguessed = input[0];

            if (!player.Guessedletter.Contains(lettersguessed))
            {
                player.Guessedletter.Add(lettersguessed);
            }

            return lettersguessed;

        }

        static void displaymaskedword()
        {
            foreach (char c in letters)
            {
                Console.Write(c);
            }
        }
        static void Endgame()
        {
            Console.WriteLine($"Thank you for playing: {player.name.ToUpper()}");
            Console.WriteLine($"Number of guesses: {player.Guessedletter.Count} Score : {player.Score}");
            Console.WriteLine($"You Guessed the correct word its: {correctword}");

            Console.WriteLine("Do you want to play again");

            clue = Console.ReadLine();

            if (clue == "y")
            {
                Startgame();
                Playgame();
                Endgame();
            }
          
        }
    }
}


