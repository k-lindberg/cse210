using System;
using System.Collections.Generic;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        float sum = 0;

        foreach (float n in numbers)
        {
            sum += n;
        }

        Console.WriteLine($"The sum is: {sum}");

        int amount = numbers.Count;
        float average = sum / amount;

        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];

        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

    }
}