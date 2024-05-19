using System;
using System.Security.Cryptography.X509Certificates;
class Entry {
    private DateTime todaysDate;
    private string _getDay;
    private string _today;
    private string _prompt;
    private string _entry;
    private List<string> _entryList;
    private PromptGenerator _promptClass = new PromptGenerator();

    private string GetDate()
    {
        todaysDate = DateTime.Now;
        _getDay = todaysDate.ToString("yyyy/MM/dd hh:mm tt");

        return _getDay;  
    }

    public List<string> CreateEntry()
    {
        _today = GetDate();
        _prompt = _promptClass.GeneratePrompt();
        
        Console.WriteLine(_today);
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();

        _entryList = new List<string>()
        {
                _today,
                _prompt,
                _entry
        };

        return _entryList;

    }
}