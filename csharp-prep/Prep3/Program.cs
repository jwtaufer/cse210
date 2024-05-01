using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        Console.Write("What is your guess? ");
        string userInput2 = Console.ReadLine();
        int userGuess = int.Parse(userInput2);

        if (userGuess > magicNumber)
        {
            Console.Write("Lower");
        }
        else if (userGuess < magicNumber)
        {
            Console.Write("Higher");
        }
        else if (userGuess == magicNumber)
        {
            Console.Write("You guessed it!");
        }
        else
        {
            Console.Write("Error");
        }
    }
}