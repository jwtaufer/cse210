using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        Console.WriteLine("Guess a number between 1 and 100.");

        int userGuess;

        do
        {
            Console.WriteLine("What is your guess? ");
            string userInput2 = Console.ReadLine();
            userGuess = int.Parse(userInput2);
            
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Error");
            }
        } while (userGuess != magicNumber);
    }
}