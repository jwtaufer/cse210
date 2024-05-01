using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
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