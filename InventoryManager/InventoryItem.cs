using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager
{
    class InventoryItem
    {
        private string itemName;
        private string itemDescr;
        private int itemNum;
        private double price;
        private int stock;

        //Constructor methods
        //No-args constructor gives default values to be defined by setters
        public InventoryItem()
        {
            itemName = "Unknown";
            itemDescr = "Unknown";
            itemNum = 999;
            price = 999.99;
        }

        //Initializes with values for all data points
        public InventoryItem(string itemName, string itemDescr, int itemNum, double price, int stock)
        {
            this.itemName = itemName;
            this.itemDescr = itemDescr;
            this.itemNum = itemNum;
            this.price = price;
            this.stock = stock;
        }

        public InventoryItem(InventoryItem item)
        {
            this.itemName = item.getItemName();
            this.itemDescr = item.getDescr();
            this.itemNum = item.getItemNum();
            this.price = item.getPrice();
            this.stock = item.getStock();
        }


        //getter and setter methods for variables
        public int getItemNum()
        {
            return itemNum;
        }

        public void setItemNum(int itemNum)
        {
            this.itemNum = itemNum;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public string getItemName()
        {
            return itemName;
        }

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public string getDescr()
        {
            return itemDescr;
        }

        public void setDescr(string itemDescr)
        {
            this.itemDescr = itemDescr;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
        
        public static void printItem(InventoryItem item)
        {
            Console.Write("Item name: " + item.getItemName() + " || " + "Item description: " +
                item.getDescr() + " || " + " Item number: " + item.getItemNum() + " || " + "Price: $" + item.getPrice() +
                " || " + "Stock count: " + item.getStock());
            Console.WriteLine();
        }
    }
}
