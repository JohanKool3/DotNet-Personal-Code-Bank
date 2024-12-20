using HigherOrLower.Cli.Helpers;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tracking Game State
        var maxAttempts = 7;
        var attempts = 0;
        var gameWon = false;

        var numberToGuess = NumberGenerator.Generate(0, 100);
        Console.WriteLine("I am thinking of a number between 0 and 100");

        while (attempts < maxAttempts && !gameWon)
        {
            Console.Write("Your Guess: ");
            var userInput = Console.ReadLine();

            var successful = int.TryParse(userInput, out int userGuess);

            if (!successful)
            {
                Console.WriteLine("Invalid Input");
                continue;
            }

            // Check the number
            if (userGuess == numberToGuess)
            {
                attempts++;
                gameWon = true;
            }
            else if (userGuess > numberToGuess)
            {
                attempts++;
                Console.WriteLine($"({attempts}/{maxAttempts}) You Guessed Higher");

            }
            else
            {
                attempts++;
                Console.WriteLine($"({attempts}/{maxAttempts}) You Guessed Lower");

            }
        }

        if (gameWon)
        {
            Console.WriteLine("You Guessed Correctly! You Win");
            Console.WriteLine($"Total Guesses {attempts} / {maxAttempts}");
        }
        else
        {
            Console.WriteLine("You ran out of guesses! You Lose");
            Console.WriteLine($"Total Guesses {attempts} / {maxAttempts}");
        }
    }
}