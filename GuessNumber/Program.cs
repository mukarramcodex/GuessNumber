//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class GuessTheNumber
{
    static void Main()
    {
        Console.WriteLine("=== Guess the Number Game ===");
        Random random = new Random();
        int numberToGuess = random.Next(1, 13); // 1 to 12
        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Guess a number between 1 and 12: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < numberToGuess)
                Console.WriteLine("Too Low!");
            else if (guess > numberToGuess)
                Console.WriteLine("Too High!");
            else
                Console.WriteLine($"Correct! You Guessed it in {attempts} attempts.");
        } while (guess != numberToGuess);
    }
}
