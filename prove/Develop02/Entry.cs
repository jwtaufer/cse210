using System;
class Entry {
    private DateTime todaysDate;
    private string _today;
    public string _entry;
    public string _prompt;

     public Entry() {
        DateTime todaysDate = DateTime.Now;
        _today = todaysDate.ToString("yyyy/MM/dd hh:mm tt");
    }

    public void DisplayEntry() {
        Console.WriteLine(_today);
        Console.WriteLine(_prompt);
        Console.WriteLine($"{_entry}");
    }
}