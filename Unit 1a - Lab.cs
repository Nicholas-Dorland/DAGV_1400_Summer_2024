using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Nibichibolibas";
      string greet = $"Hello, and welcome {name}!";
      Console.WriteLine(greet);  

      int fish = 1;                           //An intiger to start off with.
      string rhymeA = $"{fish} fish,";        //And something to use the int with.
      Console.WriteLine(rhymeA);              //Gotta see how we're doing!
      fish++;                                 //Moving up one level.
      string rhymeAB = $"{fish} fish,";
      Console.WriteLine(rhymeAB);             //Starting to sound familiar...
      string fishOne = "Red";
      string rhymeB = $"{fishOne} fish,";
      Console.WriteLine(rhymeB);
      string fishTwo = "Blue";
      string rhymeBB = $"{fishTwo} fish.";    //Wishing I had a way to replace strings...
      Console.WriteLine(rhymeBB);

      double pi = 3.141592652;                //Get some double variables action now.
      string tieIn = "With all of this fish, I wish I had some Pi!";
      Console.WriteLine(tieIn);
      Console.WriteLine(pi);
      bool isPi = false;                      //With some bool practice!
      if (pi == 3.141592652)                  //Stepping it up with a singular if statement.
      {
        isPi = true;
      }
      Console.WriteLine(isPi);
                                              //And here is where I stop wasting time. 
                                        
      string downToBusiness = "Guess I should do the rest of the assignment, right?";
      Console.WriteLine(downToBusiness);

      char hopefulGrade = 'A';
      int start = 6;
      int add = 5;
      int eleven = start % add;
      bool isEleven = (eleven != 11) ? true : false;
     }
  }
}