/*Below is the example code that was given through the videos.*/
using System;

public class Program
{
    public void Main()
    {
        Console.WriteLine("Welcome");
        DoMath(10, 4);
        DoMath(20, 7);
        DoMath(30, 15);
        Compare(4, 3);
        Compare(3, 4);
        CheckPassword("SevenOF9");
        CheckPassword("OU812");
    }

    public void DoMath(int value, int value2) {
        var number = value + value2;
        Console.WriteLine(number);
    }

    public void Compare (int value, int value2) {
        if(value > value2) {
            Console.WriteLine("True, the first is greater.");
        }
        else {
            Console.WriteLine("False, the second is greater.");
        }
    }

    public void CheckPassword (string password) {
        if (password == "OU812") {
            Console.WriteLine("Correct Password");
        }
        else {
            Console.WriteLine("Incorrect Password");
        }
    }
}

/*Here lies the code that was tested during the Try it Yourself sections.
  Sadly, the Try it Yourself buttons are broken, but the excercise is still here.*/

//If Statements
int a = 12;
int b = 13;
string result = (a == b) ? "Thank you!" : "Are you sure you counted that right?";
Console.WriteLine(result);
if (a < b) {
    Console.WriteLine("No, I asked for a BAKER'S Dozen!");
}

//Switches
int day = 4;
switch (day) 
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Welcome back, Dianne."); //The Eighth Day by Dianne K Salerni
        break;
}
