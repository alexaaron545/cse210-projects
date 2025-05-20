using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumInteger = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumInteger != 0)
        {
            Console.Write("Enter number: ");
            string userNum = Console.ReadLine();

            userNumInteger = int.Parse(userNum);

            if (userNumInteger != 0)
            {
                numbers.Add(userNumInteger);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum = number + sum;
        }

        Console.WriteLine($"The sum is: {sum}");

        double sumDecimal = sum;
        double average = sumDecimal / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;

        foreach (int number in numbers)
        {
            if (largestNumber < number)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}