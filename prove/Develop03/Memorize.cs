using System;

class Memorize
{
    private bool _memorize;
    private References _alma711r = new References();
    private string _reference;
    private Scriptures _alma711s = new Scriptures();
    private string _scripture;
    private string _userInput;
    public Memorize()
    {
        _memorize = true;
        _reference =_alma711r.Alma711();
        _alma711s = new Scriptures();
    }
    public void Alma711()
    {
        while (_memorize)
        {
            Console.WriteLine(_alma711r.Alma711());
            Console.WriteLine("Tap 'Enter' to continue memorizing,");
            Console.WriteLine("or type 'quit' to exit.");

            Console.WriteLine();
            Console.Write("Input: ");
            _userInput = Console.ReadLine();

            switch (_userInput.ToLower())
            {
                case "":
                    break;
                case "quit":
                    _memorize = false;
                    break;
                case "2":
                    _memorize = false;
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Press 'Enter' or type 'quit'.");
                    break;
            }
        }
    }
}