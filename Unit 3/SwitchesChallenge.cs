/*This program will demonstrate how to compare class variables and output a reaction
  based on the specific input. Here we will be using Pokimons, to avoid copywrite.*/
using System;

public class Program
{
    //Two new classes: one for a Pokimon, and another for a Pokimon's move.
    //These will probably be mixed if a future project will require new classes.
    public Pokimon pokimon;
    public Move move;

    public static void Main()
    {
        var pokimon = new Pokimon();
        var move = new Move();

        pokimon.name = "Charizard";
        pokimon.type = "Fire";

        //A call for the user to input a move type. Sadly, it reads a file, so 
        //there is no prompt for this user this time.
        Console.WriteLine("A wild Charizard has appeared!");
        Console.WriteLine("What type of move will you use?");

        move.type = Console.ReadLine();

        //A switch to display the effectiveness of a move type based on the fire-type
        //Charizard.
        switch (move.type)
        {
            case "Fire":  //These types are going to do half damage.
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
            case "Water":  //These types will do double damage
                Console.WriteLine("It's super effective!");
                break;
            case "Ground":
                Console.WriteLine("It's super effective!");
                break;
            case "Rock":
                Console.WriteLine("It's super effective!");
                break;
            default:    //Any other type of move will be a normal hit.
                Console.WriteLine("It's a good hit!");
                break;
        }
    }

    //The Pokimon Class
    public class Pokimon
    {
        public string name;
        public string type;
    }

    //The Move Class
    public class Move
    {
        public string type;
    }
}