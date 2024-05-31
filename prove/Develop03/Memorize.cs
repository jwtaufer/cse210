using System;

class Memorize
{
    private bool _memorize;
    private References _alma711r;
    private string _reference;
    private Scriptures _alma711s;
    private string _scripture;
    private string _userInput;
    public Memorize()
    {
        _memorize = true;
        _alma711r = new References("Alma 7:11");
        _alma711s = new Scriptures();
        _reference = _alma711r.Alma711();
        _scripture = _alma711s.Alma711();
    }
    public void Alma711()
    {
        while (_memorize)
        {
            Console.Clear();
            Console.WriteLine(_reference);
            Console.WriteLine(_scripture);
            Console.WriteLine("Tap 'Enter' to continue memorizing,");
            Console.WriteLine("or type 'quit' to exit.");

            Console.WriteLine();
            Console.Write("Input: ");
            _userInput = Console.ReadLine();

            switch (_userInput.ToLower())
            {
                case "quit":
                    _memorize = false;
                    break;
                case "2":
                    _memorize = false;
                    break;
                default:
                    break;
            }
        }
    }
}