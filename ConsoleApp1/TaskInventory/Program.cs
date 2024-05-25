namespace TaskInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddProduct("Phone", 5);
            inventory.RemoveProduct("Phone");
            inventory.GetQuantityByProduct("Phone");
            inventory.AddProduct("Laptop", 10);
            inventory.GetQuantityByProduct("Laptop");
            inventory.UpdateQuantity("Phone", 12);
            inventory.GetQuantityByProduct("Phone");
        }
    }
}
