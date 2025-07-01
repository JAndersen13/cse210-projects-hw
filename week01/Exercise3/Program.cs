using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber;
        
        do
        {
            Console.WriteLine("");
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (magicNumber > guessNumber)
            {
                Console.Write("Higher");
            }

            else if (magicNumber < guessNumber)
            {
                Console.Write("Lower");
            }

            else
            {
                Console.Write("You guessed it!");
            }

        } while (guessNumber != magicNumber);

    }    
}