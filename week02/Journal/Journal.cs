using System.Globalization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty. Write an entry first!");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Loading from file....");
        _entries.Clear();

        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File '{filename}' not found. No entries loaded.");
                return;
            }
            string[] lines = File.ReadAllLines(filename);


            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");

                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];
                string emotion = parts[3];
                Entry loadedEntry = new Entry(date, prompt, entryText, emotion);
                _entries.Add(loadedEntry);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Warning: {ex.Message}");
        }
        if (_entries.Count > 0)
        {
            DisplayAll();
        }
    }
    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file....");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}~~{entry._entryEmotion}");
            }
        }
    }
}
