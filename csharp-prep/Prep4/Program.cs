using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber 1=0);
        {
            Console.Write ("Please enter a number: ");

            string userResponsee = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.
        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the maximum, or largest, number in the list.
            int maximum = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maximum)
                {
                    maximum = number;
                }
            }
            Console.WriteLine($"The largest number is: {maximum}");
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }
}