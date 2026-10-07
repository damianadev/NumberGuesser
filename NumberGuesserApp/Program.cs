using System;

public static class NumberGuesser
{
    static int number = new Random().Next(1, 101);

    public static void Main()
    {
        Console.WriteLine(number);

        Console.WriteLine("Guess a number 1-100!");

        Guesser();
    }

    public static void Guesser()
    {
        string? numberStr = Console.ReadLine();

        int numberInt = Convert.ToInt32(numberStr);


        if (numberInt == number)
        {
            Console.WriteLine("You guessed a number!");
        }
        else if (numberInt < number)
        {
            Console.WriteLine("Higher!");
            Console.WriteLine("Try again.");

            Guesser();
        }
        else if (numberInt > number)
        {
            Console.WriteLine("Lower!");
            Console.WriteLine("Try again.");
            Guesser();
        }

    }
}