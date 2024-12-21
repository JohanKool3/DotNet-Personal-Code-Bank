using ShoppingListManager.Cli.Models;

namespace ShoppingListManager.Cli.Helpers
{
    /// <summary>
    /// A Simple object that stores a collection of items on a shopping list
    /// </summary>
    public class ShoppingList
    {
        private List<ShoppingItem> _items = [];

        /// <summary>
        /// Adds an item to the shopping list
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(ShoppingItem item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Removes a given item from the shopping list
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(int index)
        {
            var item = GetItem(index);

            // Cannot fetch item as it is not a valid item
            if (item is null)
            {
                return;
            }

            _items.Remove(item);
        }

        /// <summary>
        /// Removes all items from the shopping list
        /// </summary>
        public void Clear()
        {
            _items.Clear();
        }

        /// <summary>
        /// Gets all items in the shopping list
        /// </summary>
        /// <returns></returns>
        public List<ShoppingItem> GetAll()
        {
            return _items;
        }

        /// <summary>
        /// Gets a specific item in the shopping list (by index)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ShoppingItem? GetItem(int index)
        {
            // Cannot return an item as out of bounds
            if (index < 0 || index > _items.Count)
            {
                return null;
            }

            return _items[index];
        }

    }
}
