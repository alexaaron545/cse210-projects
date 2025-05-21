using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int numberConverted = int.Parse(number);
            return numberConverted;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        static void DisplayResult(string usersName, int squaredNumber)
        {
            Console.WriteLine($"{usersName}, the square of your number is {squaredNumber}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }
}