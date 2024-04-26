using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string strGrade = Console.ReadLine();
        int intGrade = int.Parse(strGrade);

        string letter = "";

        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80)
        {
            letter = "B";
        }
        else if (intGrade >= 70)
        {
            letter = "C";
        }
        else if (intGrade >= 60)
        {
            letter = "D";
        }
        else if (intGrade < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "error";
        }

        Console.WriteLine($"Your grade: {letter}");

        if (intGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, but you need at least 70% to pass. Better luck next time.");
        }
    }
}