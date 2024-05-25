using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInventory
{
    internal class Inventory
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        public Inventory() 
        {
            inventory = new Dictionary<string, int>();
        }
        public void AddProduct(string productName, int quantity)
        {
            inventory.Add(productName, quantity);
        }
        public void RemoveProduct(string productName)
        {
            inventory.Remove(productName);
        }
        public void UpdateQuantity(string productName, int quantity)
        {
            inventory[productName] = quantity;
        }
        public void GetQuantityByProduct(string productName)
        {
            if (inventory.ContainsKey(productName))
                Console.WriteLine(productName + " " + inventory[productName]);
            else
                Console.WriteLine("Invalid name");
        }
    }
}
