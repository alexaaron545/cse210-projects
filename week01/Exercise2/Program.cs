using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;

        Console.Write("What is your grade percentage? ");
        string inputFromUser = Console.ReadLine();

        int inputFromUserConverted = int.Parse(inputFromUser);


        if (inputFromUserConverted >= 90)
        {
            letter = "A";
        }
        else if (inputFromUserConverted >= 80)
        {
            letter = "B";
        }
        else if (inputFromUserConverted >= 70)
        {
            letter = "C";
        }
        else if (inputFromUserConverted >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (inputFromUserConverted >= 70)
        {
            Console.WriteLine($"Congratulations for passing the class!");
        }
        else
        {
            Console.WriteLine($"Sorry, You didn't pass the class, try better next time!");
        }
    }
}