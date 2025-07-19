using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
            return;
        }
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("----------------------");
        }
    }
    
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string prompt = EscapeCsv(entry.Prompt);
                string response = EscapeCsv(entry.Response);
                string date = EscapeCsv(entry.Date);
                string mood = EscapeCsv(entry.Mood);
                string weather = EscapeCsv(entry.Weather);
                
                writer.WriteLine($"\"{date}\",\"{prompt}\",\"{response}\",\"{mood}\",\"{weather}\"");
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = ParseCsvLine(line);
            
            if (parts.Length >= 5)
            {
                Entry entry = new Entry
                {
                    Date = UnescapeCsv(parts[0]),
                    Prompt = UnescapeCsv(parts[1]),
                    Response = UnescapeCsv(parts[2]),
                    Mood = UnescapeCsv(parts[3]),
                    Weather = UnescapeCsv(parts[4])
                };
                
                _entries.Add(entry);
            }
        }
    }
    
    private string EscapeCsv(string input)
    {
        if (input == null) return "";
        return input.Replace("\"", "\"\"");
    }
    
    private string UnescapeCsv(string input)
    {
        if (input == null) return "";
        return input.Replace("\"\"", "\"");
    }
    
    private string[] ParseCsvLine(string line)
    {
        List<string> parts = new List<string>();
        bool inQuotes = false;
        int start = 0;
        
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (line[i] == ',' && !inQuotes)
            {
                string part = line.Substring(start, i - start).Trim('"');
                parts.Add(part);
                start = i + 1;
            }
        }
        
        if (start < line.Length)
        {
            string part = line.Substring(start).Trim('"');
            parts.Add(part);
        }
        
        return parts.ToArray();
    }
}