using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager
{
    class InventoryManager
    {
        private List<InventoryItem> inventory;


        public InventoryManager()
        {
            inventory = new List<InventoryItem>();
        }

        public void addItem(InventoryItem item)
        {
            inventory.Add(item);
        }

        public bool removeItem(string name)
        {
            bool success = false;
            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    inventory.Remove(item);
                    success = true;
                }
            }
            return success;
        }

        public InventoryItem SearchByName(string name)
        {
            InventoryItem temp = new InventoryItem("Item not found", "Item not found", 0000, 0.00, 0);

            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    temp = item;
                }
            }
            return temp;
        }

        public InventoryItem SearchByPrice(double price)
        {
            InventoryItem temp = new InventoryItem("Item not found", "Item not found", 0000, 0.00, 0);

            foreach (InventoryItem item in inventory)
            {
                if (item.getPrice() == price)
                    temp = item;
               
                    
            }

            return temp;
        }

        public void RestockItem(string name)
        {
            foreach (InventoryItem item in inventory)
            {
                if (item.getItemName().Equals(name))
                {
                    if (item.getStock() == 0)
                    {
                        item.setStock(5);
                    }
                    else
                    {
                        Console.WriteLine("Stock of item is: " + item.getStock());
                    }
                }
                else
                    Console.WriteLine("Item not found");
            }
        }
    }
}
