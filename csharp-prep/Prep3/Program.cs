using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World! And Number Guessing Game!!!.");
        int magicNumber;
        int userGuess;

        int guessCount = 0;
        string keepPlaying = "yes";

        while (keepPlaying == "yes")

        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 100);
            do
            {

                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount = guessCount + 1;
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (userGuess != magicNumber);
            Console.WriteLine($"It took you {guessCount} Guesses");
            Console.Write("Do you want keep playing? ");
            keepPlaying = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing.");
    }
}