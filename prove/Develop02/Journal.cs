using System;
using System.IO;
using System.IO.Enumeration;
// Do I need all three of the lines above? Or would one of these statements do the job? If so, which one?

class Journal {
    public string _myFile;
    public List<List<string>> _entries = new List<List<string>>();

    public void Load() {
        Console.Write("Put file in the same folder as 'Program.cs' then press 'Enter'.");
        Console.ReadLine();
        Console.Write("Enter the filename: ");
        _myFile = Console.ReadLine();

        string[] entries = System.IO.File.ReadAllLines(_myFile);

        foreach (string line in entries)
        {
            string[] parts = line.Split("|");

            List<string> entry = new List<string>()
            {
                parts[0],
                parts[1],
                parts[2]
            };

            _entries.Add(entry);
        }

        foreach (List<string> entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry[0]}");
            Console.WriteLine($"Prompt: {entry[1]}");
            Console.WriteLine($"Entry: {entry[2]}");
        };
        Console.WriteLine();
    }

    public void Save() {
        
    }
}