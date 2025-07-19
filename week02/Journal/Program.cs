using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        // Exceeding requirements: Added mood tracking and weather to entries
        // Also implemented CSV handling with quotation marks
        Console.WriteLine("Welcome to your Journal Program!");
        
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    
                    // Exceeding requirements: Collect additional info
                    Console.Write("How are you feeling today (mood)? ");
                    string mood = Console.ReadLine();
                    Console.Write("What's the weather like today? ");
                    string weather = Console.ReadLine();
                    
                    Entry newEntry = new Entry
                    {
                        Prompt = prompt,
                        Response = response,
                        Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                        Mood = mood,
                        Weather = weather
                    };
                    
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;
                    
                case "2":
                    journal.DisplayAll();
                    break;
                    
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    break;
                    
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;
                    
                case "5":
                    running = false;
                    break;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}