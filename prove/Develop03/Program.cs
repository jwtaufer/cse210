using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        string userInput;
        Memorize alma711 = new Memorize();

        Console.WriteLine();
        Console.WriteLine("Which scripture would you like to memorize?");
        
        while (run)
        {
            Console.WriteLine();
            Console.WriteLine("1. Alma 7:11-13");
            Console.WriteLine("2. Quit");
            
            Console.WriteLine();
            Console.Write("Input: ");
            userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "1":
                    alma711.Alma711();
                    break;
                case "2":
                    run = false;
                    break;
                case "quit":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Enter a number between 1 and 2.");
                    break;
            }     
        }
    }
}