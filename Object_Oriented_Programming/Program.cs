using Object_Oriented_Programming.InventoryManagement;
using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        const String Inventory_Json = @"E:\Bridglabz\OOPs_concept\Object_Oriented_Programming\InventoryManagement\Inventory.json"; //@ define path
        static void Main(string[] args)
        {
            String Choice = "";
            InventoryManager main = new InventoryManager();
            Console.WriteLine("Enter 'add' if u want to Add a item");
            Console.WriteLine("Enter 'edit' if u want to Edit an item");
            Console.WriteLine("Enter 'delete' if u want to Delete a item");
            Console.WriteLine("Enter 'disp' if u want to Display the items");
            while (Choice != "stop")
            {
                Choice = Console.ReadLine().ToLower();
                switch (Choice)
                {
                    case "edit":
                        main.Edit(Inventory_Json);
                        break;

                    case "disp":
                        main.DisplayData(Inventory_Json);
                        break;

                    case "delete":
                        main.Deleteitems(Inventory_Json);
                        break;

                    case "add":
                        main.Additems(Inventory_Json);
                        break;

                }
            }

        }
    }
}
