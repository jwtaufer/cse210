using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        string userInput;
        Memorize alma711;
        
        while (run)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Which scripture would you like to memorize?");
            Console.WriteLine();
            Console.WriteLine("1. Alma 7:11-13");
            Console.WriteLine("2. Quit");
            
            Console.WriteLine();
            Console.Write("Input: ");
            userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "1":
                    Console.WriteLine("Which verse would you like to memorize?");
                    Console.WriteLine("1. First verse");
                    Console.WriteLine("2. Second verse");
                    Console.WriteLine("3. Third verse");
                    Console.WriteLine("4. All verses");
                    Console.Write("Input: ");
                    userInput = Console.ReadLine();
                    switch (userInput.ToLower())
                    {
                        case "1":
                            alma711 = new Memorize();
                            alma711.Alma711();
                            break;
                        case "4":
                            break;
                        case "quit":
                            break;
                    }
                    break;
                case "2" or "quit":
                    Console.Clear();
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Enter a number between 1 and 2.");
                    break;
            }     
        }
    }
}