using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine("How are you feeling today? (happy, sad, stressed, excited, etc.) ");
        string mood = Console.ReadLine();

        PromptGenerator promptGen = new PromptGenerator();
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("> ");
        string entryText = Console.ReadLine();

        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._mood = mood;
        newEntry._promptText = prompt;
        newEntry._entryText = entryText;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._mood}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._mood = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];

            _entries.Add(entry);
        }
    }
}