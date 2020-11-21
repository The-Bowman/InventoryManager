using System;

namespace InventoryManager
{
    class Driver
    {
        static void Main(string[] args)
        {
            InventoryManager inventory = new InventoryManager();

            InventoryItem item1 = new InventoryItem("X-Wing", "Model Rebellion Starfighter", 111111, 29.99, 3);
            InventoryItem item2 = new InventoryItem("Asus Tuf Gaming 3080", "NVIDIA 3080 Graphics Card", 222222, 799.99, 1);
            InventoryItem item3 = new InventoryItem("Nightstalker", "Destiny Hunter Figurine", 333333, 39.99, 6);
            InventoryItem item4 = new InventoryItem("Firefly", "Blu-ray and 4k edition", 444444, 49.99, 0);

            // display items
            InventoryItem.printItem(item1);
            InventoryItem.printItem(item2);
            InventoryItem.printItem(item3);
            InventoryItem.printItem(item4);

            // add items to inventory
            inventory.addItem(item1);
            inventory.addItem(item2);
            inventory.addItem(item3);
            inventory.addItem(item4);

            Console.WriteLine();
            Console.WriteLine("After adding items to the Inventory Manager: ");
            Console.WriteLine();

            // display items in the manager
            inventory.showAllItems();

            // create a temp item to hold result of search
            InventoryItem temp = new InventoryItem((inventory.SearchByName("Nightstalker")));

            // display item searched for
            InventoryItem.printItem(temp);

            Console.WriteLine();
            Console.WriteLine();
            temp = inventory.SearchByPrice(29.99);
            InventoryItem.printItem(temp);

            Console.WriteLine();
            Console.WriteLine();

            inventory.removeItem("Asus Tuf Gaming 3080");

            // display inventory after removing item
            inventory.showAllItems();

            inventory.RestockItem("Firefly");

            // display inventory after restocking item
            Console.WriteLine();
            inventory.showAllItems();

        }
    }
}
