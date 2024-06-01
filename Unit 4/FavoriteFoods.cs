using System;

public class Program
{
    public static void Main()
    {
        // Step 1: Ask the user for their favorite foods
        Console.WriteLine("Let's list your favorite foods!");
        string[] favoriteFoods = new string[5]; // Fixed-size array for simplicity

        for (int i = 0; i < favoriteFoods.Length; i++)
        {
            Console.Write($"Enter favorite food #{i + 1}: ");
            favoriteFoods[i] = Console.ReadLine();
        }

        // Step 2: Iterate through the array and print messages
        Console.WriteLine("\nHere are your favorite foods:");
        foreach (string food in favoriteFoods)
        {
            //Nicholas Dorland - Checks if the food ends with a plural.
            if (food.EndsWith("s"))
            {
                Console.WriteLine($"{food} are so good!");
            }
            else
            {
                Console.WriteLine($"I love {food}!");
            }
        }
    }
}