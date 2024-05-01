using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = 1;
        int iteration = 0;
        int sum = 0;
        int average = 0;
        int maximum = 0;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            
            if (number != 0)
            {
                numbers.Add(number);
                iteration++;
                sum += number;

                if (number > maximum)
                {
                    maximum = number;
                }
            }
        }

        average = sum/iteration;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}