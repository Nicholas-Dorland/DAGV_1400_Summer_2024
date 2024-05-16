using System;

public class Program
{
    public Hero heroOne;
    public Hero heroTwo;

    public void Main()
    {
        heroOne = new Hero();
        heroTwo = new Hero();

        //Default Hero One attributes
        heroOne.health = 2;
        heroOne.powerLevel = 5;
        //New Hero One attributes
        heroOne.capeColor = "Yellow";
        heroOne.suitLetter = 'G';

        //Defualt Hero Two attributes
        heroTwo.health = 3;
        heroTwo.powerLevel = 1;
        //New Hero Two attributes
        heroTwo.capeColor = "Red";
        heroTwo.suitLetter = 'T';

        //Written old Hero One information
        Console.WriteLine(heroOne.health);
        Console.WriteLine(heroOne.powerLevel);
        //New written Hero One information
        Console.WriteLine(heroOne.capeColor);
        Console.WriteLine(heroOne.suitLetter);

        //Written old Hero Two information
        Console.WriteLine(heroTwo.health);
        Console.WriteLine(heroTwo.powerLevel);
        //New written Hero Two information
        Console.WriteLine(heroTwo.capeColor);
        Console.WriteLine(heroTwo.suitLetter);
    }
}

pubilc class Hero {
    //Defualt variables for Hero Class
    public int health;
    public int powerLevel;

    //New variables for Hero Class
    public string capeColor;
    public char suitLetter;
}