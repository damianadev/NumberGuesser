using System;

public static class NumberGuesser
{
    static int number = new Random().Next(1, 101);

    public static void Main()
    {
        // Console.WriteLine(number);

        Console.WriteLine("Guess a number 1-100!");

        Guesser();
    }

    public static void Guesser()
    {
        int numberInt;

        do
        {
            string? numberStr = Console.ReadLine();

            numberInt = Convert.ToInt32(numberStr);


            if (numberInt < 1 || numberInt > 100)
            {
                Console.WriteLine("Enter a number from 1 to 100!");
            }
            else if (numberInt < number)
            {
                Console.WriteLine("Higher!");
                Console.WriteLine("Try again.");
            }
            else if (numberInt > number)
            {
                Console.WriteLine("Lower!");
                Console.WriteLine("Try again.");
            }
            else
            {
                Console.WriteLine("You guessed a number!");
            }

        }
        while (numberInt != number);
    }

}