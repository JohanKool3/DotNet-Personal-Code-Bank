using ShoppingListManager.Cli.Helpers;
using ShoppingListManager.Cli.Models;

internal class Program
{
    private static bool _running = true;
    private static readonly ShoppingList _shoppingList = new();
    private static void Main(string[] args)
    {

        while (_running)
        {
            Console.WriteLine("""
            1. Show List
            2. Add Item
            3. Remove Item
            4. Clear List
            5. Quit
            """);

            // Take User Input
            Console.Write("Enter your option: ");
            var userInput = Console.ReadLine();

            // Validate Input
            var option = InputValidator.ValidateOption(userInput, 1, 5);

            switch (option)
            {
                case -1:
                    Console.WriteLine("Invalid Input");
                    break;

                case 1:
                    DisplayAll();
                    break;

                case 2:
                    AddItem();
                    break;
                case 3:
                    RemoveItem();
                    break;
                case 4:
                    ClearList();
                    break;
                case 5:
                    _running = false;
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    private static void RemoveItem()
    {
        DisplayAll();
        Console.Write("Which Index do you want to delete? : ");
        var option = Console.ReadLine();

        var allItemsAmount = _shoppingList.GetAll().Count;
        var validatedOption = InputValidator.ValidateOption(option, (allItemsAmount > 0) ? 1 : 0, allItemsAmount);

        if (validatedOption == -1)
        {
            Console.WriteLine("Invalid Option");
        }

        _shoppingList.RemoveItem(validatedOption - 1); // Convert back to 0 indexed list
    }

    private static void ClearList()
    {
        _shoppingList.Clear();
    }

    private static void AddItem()
    {
        Console.Write("Enter Item Name: ");
        var itemName = Console.ReadLine();

        Console.Write($"{itemName} Amount: ");
        var itemAmountInput = Console.ReadLine();

        if (itemName is null || itemName == string.Empty)
        {
            Console.WriteLine("Item Name must not be empty or null");
            return;
        }
        var itemAmount = InputValidator.ValidateOption(itemAmountInput, 0, int.MaxValue);

        if (itemAmount == -1)
        {
            Console.WriteLine("Invalid Amount must be a number");
            return;
        }

        _shoppingList.AddItem(new ShoppingItem { Name = itemName ?? "Unknown", Quantity = itemAmount });
    }

    private static void DisplayAll()
    {
        var allItems = _shoppingList.GetAll();
        if (allItems.Count <= 0)
        {
            Console.WriteLine();
            Console.WriteLine("**  List is Empty  **");
            Console.WriteLine();
            return;
        }

        // Display List (Iterate over all Items)
        Console.WriteLine();
        for (int index = 0; index < allItems.Count; index++)
        {
            var item = allItems[index];
            var originalString = $"{index + 1}. {item.Name} | {item.Quantity}";

            Console.WriteLine($"{index + 1}. {item.Name} | {item.Quantity}");
        }
        Console.WriteLine();
    }
}