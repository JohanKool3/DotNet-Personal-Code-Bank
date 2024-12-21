using SimpleCalculator.Cli.Helpers;
using Validators.Library.Cli;

internal class Program
{
    private static float currentValue = 0;
    private static void Main(string[] args)
    {

        var running = true;
        while (running)
        {
            Console.WriteLine($"Current Value: {currentValue}");
            Console.Write("""
            1. Add
            2. Subtract
            3. Multiply
            4. Divide
            5. Quit
            """);
            Console.WriteLine();

            // Take User Input
            Console.Write("Enter Your Option: ");
            var userInput = Console.ReadLine();

            var option = InputValidator.ValidateOption(userInput, 1, 5);

            switch (option)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                case 5:
                    running = false;
                    break;
            }
        }
    }

    private static void Divide()
    {
        Console.Write($"{currentValue} / ");
        var userValue = Console.ReadLine();

        var validInput = InputValidator.ValidateOption(userValue, float.MinValue, float.MaxValue);

        if (validInput)
        {
            // We know that it is valid as we have validated it before
            currentValue = Calculator.Divide(currentValue, (float.Parse(userValue!)));
            return;
        }

        Console.WriteLine("Invalid Input, Must be a Number");
    }

    private static void Multiply()
    {
        Console.Write($"{currentValue} * ");
        var userValue = Console.ReadLine();

        var validInput = InputValidator.ValidateOption(userValue, float.MinValue, float.MaxValue);

        if (validInput)
        {
            // We know that it is valid as we have validated it before
            currentValue = Calculator.Multiply(currentValue, (float.Parse(userValue!)));
            return;
        }

        Console.WriteLine("Invalid Input, Must be a Number");
    }

    private static void Subtract()
    {
        Console.Write($"{currentValue} - ");
        var userValue = Console.ReadLine();

        var validInput = InputValidator.ValidateOption(userValue, float.MinValue, float.MaxValue);

        if (validInput)
        {
            // We know that it is valid as we have validated it before
            currentValue = Calculator.Subtract(currentValue, (float.Parse(userValue!)));
            return;
        }

        Console.WriteLine("Invalid Input, Must be a Number");
    }

    private static void Add()
    {
        Console.Write($"{currentValue} + ");
        var userValue = Console.ReadLine();

        var validInput = InputValidator.ValidateOption(userValue, float.MinValue, float.MaxValue);

        if (validInput)
        {
            // We know that it is valid as we have validated it before
            currentValue = Calculator.Add(currentValue, (float.Parse(userValue!)));
            return;
        }

        Console.WriteLine("Invalid Input, Must be a Number");
    }
}