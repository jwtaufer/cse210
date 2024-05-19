using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "n";
        List<string> journalEntry;
        List<List<string>> journalFile = new List<List<string>>();

        Console.WriteLine();
        Console.WriteLine("Welcome to Journalific!");

        while (userInput.ToLower() != "y")
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userInput = Console.ReadLine();
            Console.WriteLine();

            switch(userInput)
            {
                case "1": //Write
                    Entry writeJournal = new Entry();
                    journalEntry = writeJournal.CreateEntry();
                    journalFile.Add(journalEntry);
                    break;

                case "2": //Display
                    foreach (List<string> entry in journalFile)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Date: {entry[0]}");
                        Console.WriteLine($"Prompt: {entry[1]}");
                        Console.WriteLine($"Entry: {entry[2]}");
                    }    
                    break;

                case "3": //Load
                    Journal journalClass = new Journal();
                    journalFile = journalClass.Load();
                    Console.WriteLine("File loaded.");
                    break;

                case "4": //Save
                    Journal save = new Journal();
                    save.Save(journalFile);
                    break;

                case "5": //Quit
                    Console.WriteLine("Don't forget to save!");
                    Console.Write("Are you sure you want to exit (Y/N)? ");
                    userInput = Console.ReadLine();
                    break;
                
                default:
                    Console.WriteLine();
                    Console.WriteLine($"Sorry, '{userInput}' is not a valid entry.");
                    Console.WriteLine("Please enter: 1, 2, 3, 4, or 5");
                    break;
            }    
            Console.WriteLine();
        }     
    }
}