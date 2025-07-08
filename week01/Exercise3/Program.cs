using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string playResponse = "yes";

        while (playResponse == "yes")
        {
            // Console.Write("What is your magic number? ");
            // string magicInput = Console.ReadLine();
            // int magic = int.Parse(magicInput);
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);
            Console.WriteLine("I am thinking of a magic number between 1 and 100.");
            string hint = "";
            int count = 0;
            do
            {
                Console.Write("Please guess a number. ");
                string guessInput = Console.ReadLine();
                int guess = int.Parse(guessInput);

                if (magic > guess)
                {
                    hint = "Higher";
                }
                else if (magic < guess)
                {
                    hint = "Lower";
                }
                else
                {
                    hint = "You guessed it!";
                }
                count += 1;
                Console.WriteLine($"{hint}");
            } while (hint != "You guessed it!");

            Console.WriteLine($"You found the magic number in {count} guesses.");
            Console.Write("Would you like to play again? (yes or no) ");
            playResponse = Console.ReadLine();
        }
    }
}