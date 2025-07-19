using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Mood { get; set; }  // Exceeding requirements: Added mood tracking
    public string Weather { get; set; } // Exceeding requirements: Added weather tracking
    
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine($"Weather: {Weather}");
    }
}