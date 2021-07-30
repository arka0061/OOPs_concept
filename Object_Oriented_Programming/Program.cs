using Object_Oriented_Programming.InventoryManagement;
using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        const String Inventory_Json = @"E:\Bridglabz\Object_Oriented_Programming\InventoryManagement\Inventory.json"; //@ define path
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.DisplayData(Inventory_Json);
        }
    }
}
