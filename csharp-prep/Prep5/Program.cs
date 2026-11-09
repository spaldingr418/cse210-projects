using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string userName = UsersName();
        int userNumber = FavoriteNumber();
        int squaredNumber = SquareNumber(userNumber);

        int birthYear;
        BirthYear(out birthYear);

        DisplayResult(userName, squaredNumber, birthYear);
    }
    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string UsersName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    
    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void BirthYear(out int birthYear)
    {
        Console.Write("What is your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} years old this year.");
    }
}