using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        string numberIsCorrect = "No";

        while (numberIsCorrect == "No")
        {
            Console.Write("What is your guest? ");
            string userGuess = Console.ReadLine();

            int userGuessConverted = int.Parse(userGuess);

            if (userGuessConverted == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                numberIsCorrect = "Yes";
            }
            else if (userGuessConverted > magicNumber)
            {
                Console.WriteLine("Lower");
                numberIsCorrect = "No";
            }
            else if (userGuessConverted < magicNumber)
            {
                Console.WriteLine("Higher");
                numberIsCorrect = "No";
            }
        }


    }
}