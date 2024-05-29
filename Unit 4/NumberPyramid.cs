using System;

public class Program
{
    public static void Main()
    {
        int i = 1;
        while (i < 6)
        {
            for (int x = 0; x < i; x++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            i++;
        }
    }
}