using System;

public class Program
{
    public static void Main()
    {
        // Step 1: Generate a random number between 1 and 10
        Random random = new Random();
        int numberToGuess = random.Next(1, 11); // Generates a number between 1 and 10
        int numberOfAttempts = 0;
        bool correctGuess = false;

        Console.WriteLine("Welcome to the Number Guesser game!");
        Console.WriteLine("I have generated a number between 1 and 10. Can you guess it?");

        // Step 2: Loop for user guesses
        while (!correctGuess)
        {
            Console.Write("Enter your guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            numberOfAttempts++;

            // Step 3: Conditional statements for feedback
            if (userGuess == numberToGuess)
            {
                correctGuess = true;
                Console.WriteLine($"Congratulations! You've guessed the correct number in {numberOfAttempts} attempts.");
            }
            else if (userGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }
        }
    }
}