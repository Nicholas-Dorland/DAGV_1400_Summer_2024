public class ClassExample
{

}

public class ClassWithVariables
{
    //Defualt Variables in Class
    public int number = 2;
    public string userName = "Bob";

    //New Variables for this Class
    public double gpa = 0.0;
    public char grade = 'F';
}

public class ClassWithFunctions
{
    //Defualt Function in Class
    pubilc void RunFunction()
    {
        Console.WriteLine("Running Function");
    }

    //New Functions for this Class
    double gPA = 0.0;
    char currentGrade = 'F';
    public void GetInformation()
    {
        Console.WriteLine("Please enter GPA: ");
        gPA = Console.ReadLine();
    }

    public void ReadInformation(double gPA)
    {
        if (gPA == 4.0)
        {
            Console.WriteLine("Great!");
        }
        else
        {
            Console.WriteLine("Keep Going!");
        }
    }
}