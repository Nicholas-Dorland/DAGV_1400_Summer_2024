//Based on the HelloWorld File, turn this into a class.
using System;

//Wirte a console program with a program class, and Main Function
public class MyClass
{
    //Using the new keyword create several objects
    public Pokemon pokemonOne;
    public Pokemon pokemonTwo;

    public void Main()
    {
        pokemonOne = new Pokemon();
        pokemonTwo = new Pokemon();

        pokemonOne.level = 16;
        pokemonOne.color = "Blue";
        pokemonOne.type = "Electric";

        pokemonTwo.level = 19;
        pokemonTwo.color = "Green";
        pokemonTwo.type = "Grass";

        //Console writeline the Objects variables
        Console.WriteLine(pokemonOne.level);
        Console.WriteLine(pokemonOne.color);
        Console.WriteLine(pokemonOne.type);

        Console.WriteLine(pokemonTwo.level);
        Console.WriteLine(pokemonTwo.color);
        Console.WriteLine(pokemonTwo.type);
    }
}
//Add another class with any name, add variables
public class Pokemon {
    public int level;
    public string color;
    public string type;
}