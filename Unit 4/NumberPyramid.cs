using System;

public class Program
{
    public static void Main()
    {
        /* This Line Prompts the User for a number.*/
        Console.Write("How tall is your Pyramid? Please type a whole, positive number: ");

        int y = 7;  //Convert.ToInt32(Console.ReadLine());  /*While I cannot test User Input, I'll use 7 for now.*/
        int i = 1;  /*Starting Point*/

        /*Between 1 and the number input, it will create layers.*/
        while (i <= y)
        {
            /*For each value of i, write what i is an i number of times.*/
            for (int x = 1; x <= i; x++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            i++;  /*Move to the next line of the Pyramid*/
        }
    }
}