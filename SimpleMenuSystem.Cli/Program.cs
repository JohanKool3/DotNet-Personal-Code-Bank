
using SimpleMenuSystem.Cli.Helpers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("""
    1. Output 'Hello World'
    2. Greet User
    3. Quit

    """);

        while (true)
        {
            Console.Write("Enter your option: ");
            var userInput = Console.ReadLine();
            MenuHandler.HandleInput(userInput);
        }
    }
}