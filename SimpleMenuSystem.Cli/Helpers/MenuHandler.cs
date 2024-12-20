namespace SimpleMenuSystem.Cli.Helpers
{
    public class MenuHandler
    {
        public static void HandleInput(string? input)
        {
            if (input is null)
            {
                Console.WriteLine("Input must be not null");
            }
            var validInput = int.TryParse(input, out int useroption);

            if (!validInput)
            {
                Console.WriteLine("Invalid Input, Must be a number");
            }

            else
            {
                switch (useroption)
                {
                    case 1:
                        Console.WriteLine("Hello World");
                        break;
                    case 2:
                        GreetUser();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Must be an option between 1 and 3 (Inclusive");
                        break;
                }
            }
        }

        private static void GreetUser()
        {
            Console.Write("Enter your name: ");
            var usersName = Console.ReadLine();
            Console.WriteLine($"Hello {usersName}");
        }
    }
}
