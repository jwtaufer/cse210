using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "n";
        int userNumber = 0;

        Console.WriteLine("Welcome to Journal!");

        while (userInput.ToLower() != "y")
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber == 1) //Write
            {

            }
            else if (userNumber == 2) //Display
            {

            }
            else if (userNumber == 3) //Load
            {
                Journal journal = new Journal();
                journal.Load();
            }
            else if (userNumber == 4) //Save
            {

            }
            else if (userNumber == 5) //Quit
            {
                Console.WriteLine("Don't forget to save!");
                Console.Write("Are you sure you want to exit (Y/N)? ");
                userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Sorry, {userInput} is not a valid entry.");
                Console.WriteLine("Please enter: 1, 2, 3, 4, or 5");
            }

           userNumber = 0;
        }     
    }
}