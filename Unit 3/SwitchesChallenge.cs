using System;

public class Program
{
    public Pokimon pokimon;
    public Move move;

    public static void Main()
    {
        var pokimon = new Pokimon();
        var move = new Move();

        pokimon.name = "Charizard";
        pokimon.type = "Fire";

        Console.WriteLine("A wild Charizard has appeared!");
        Console.WriteLine("What type of move will you use?");

        move.type = Console.ReadLine();

        switch (move.type)
        {
            case "Fire":
                Console.WriteLine("It's not very effective...");
                break;
            case "Grass":
                Console.WriteLine("It's not very effective...");
                break;
            case "Ice":
                Console.WriteLine("It's not very effective...");
                break;
            case "Bug":
                Console.WriteLine("It's not very effective...");
                break;
            case "Steel":
                Console.WriteLine("It's not very effective...");
                break;
            case "Fairy":
                Console.WriteLine("It's not very effective...");
                break;
            case "Water":
                Console.WriteLine("It's super effective!");
                break;
            case "Ground":
                Console.WriteLine("It's super effective!");
                break;
            case "Rock":
                Console.WriteLine("It's super effective!");
                break;
            default:
                Console.WriteLine("It's a good hit!");
                break;
        }
    }

    public class Pokimon
    {
        public string name;
        public string type;
    }

    public class Move
    {
        public string type;
    }
}