using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x  = int.Parse(valueFromUser);
        string grade = "";

        if (x >= 90)
        {
            grade = "A";
        }
        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }      
        else if (x >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Grade is: {grade}.");

        if (x >= 70)
        {
            Console.WriteLine("You passed! Horray!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass.");
        }
    }
}