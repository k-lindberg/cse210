using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int yourGuess = -1;

        while (yourGuess != magicNumber)
        {

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            yourGuess = int.Parse(guess);

            if (yourGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (yourGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}