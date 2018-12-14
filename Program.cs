using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {   char readyToPlay = 'n';
            char quit = 'n';

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("###################\n");
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("You will have to guess the word chosen by you (computer) opponent. Each time you guess a wrong letter, the drawing of the hangman will get additional lines.");
            Console.WriteLine("Once the picture is complete, you lose. If you can guess all letters in the word before that, you win. \n");
            
            Console.WriteLine("This is what it looks like when you lose: ");
            Console.WriteLine("##-##-##-##");
            Console.WriteLine("##        |");
            Console.WriteLine("##       (_)");
            Console.WriteLine("##       \\|/");
            Console.WriteLine("##        |");
            Console.WriteLine("##       / \\");
            Console.WriteLine("##");
            Console.WriteLine("##\n");

            Console.WriteLine("Not that hard, eh?");

            while (!string.Equals(readyToPlay, 'y')) {
                Console.WriteLine("Are you ready to play? (y/n)");
                readyToPlay = Console.ReadKey().KeyChar;

                if (string.Equals(readyToPlay, 'n')) {
                    Console.Clear();
                    Console.WriteLine("Aww, shucks. :(");
                    Console.WriteLine("Would you like to quit? (y/n)");
                    quit = Console.ReadKey().KeyChar;

                    if (string.Equals(quit, 'y')) {
                        Environment.Exit(0);
                    } else {
                        Console.Clear();
                        Console.WriteLine("I'll take that as a 'no'.");
                    }
                } else {
                    Console.Clear();
                    Console.WriteLine("Ha-ha. Very funny. Never heard of that joke before...");
                    Console.WriteLine("So I'm asking you again: ");
                }
            }

            Console.Clear();
            Console.WriteLine("Cool! Have fun!");
            // start game
        }

        public void Draw(int stage) {
            switch(stage) {
                case 0:
                    Console.WriteLine("##-##-##-##");

                    for (int i = 0; i < 7; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 1: 
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");

                    for (int i = 0; i < 5; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 2:
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##        |");

                    for (int i = 0; i < 4; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 3:
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##       \\|");

                    for (int i = 0; i < 4; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 4:
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##       \\|/");

                    for (int i = 0; i < 4; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 5:
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##       \\|/");
                    Console.WriteLine("##        |");
                    Console.WriteLine("##       /");
                    
                    for (int i = 0; i < 2; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 6:
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##       \\|/");
                    Console.WriteLine("##        |");
                    Console.WriteLine("##       / \\");
                    
                    for (int i = 0; i < 2; i++) {
                        Console.WriteLine("##");
                    }
                    break;
                case 7:
                    Console.WriteLine("YOU LOSE!\n");
                    Console.WriteLine("##-##-##-##");
                    Console.WriteLine("##        |");
                    Console.WriteLine("##       (_)");
                    Console.WriteLine("##       \\|/");
                    Console.WriteLine("##        |");
                    Console.WriteLine("##       / \\");
                    Console.WriteLine("##");
                    Console.WriteLine("##");
                    break;
            }
        }
    }
}
