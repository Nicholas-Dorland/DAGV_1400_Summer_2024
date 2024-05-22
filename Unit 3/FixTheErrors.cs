using System; //System needs a ';' after it.

public class Program
{
    public void Main() //Needed closing braket on Main().
    {
        Console.WriteLine("Welcome"); //Needed Opening Bracket and closing quotations
        DoMath(10, 4);                //    on the ("Welcome").
        DoMath(20, 7);
        DoMath(30, 15);
    } //Main needed a closing }.
    

    public void DoMath (int value, int value2) {
        var number = value + value2; //Needed to finish spelling "valu(e2)".
        Console.WriteLine(number); //Needs a ';' after it.
    }
}

/*I believe this is all of the errors fixed. Unfortunately, the w3schools testing
  environment continually gives me error CS5001, saying there is no 'Main' method.*/