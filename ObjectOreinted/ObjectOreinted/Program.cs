using System;

namespace ObjectOreinted
{
    class Program
    {
        static string filepath = @"C:\Users\admin\Desktop\github\ObjectOreintedPrograms\ObjectOreinted\ObjectOreinted\Files\InventoryList.json";
        static void Main(string[] args)
        {
            InventoryMain inventory = new InventoryMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Read Inventory list\n2.Display Inventory list\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        inventory.ReadData(filepath);
                        break;
                    case 2:
                        Console.WriteLine(@"WHICH LIST YOU WANT TO DISPLAY\nEnter the name in form of-:rice\wheat\pulse");
                        string name = Console.ReadLine();
                        inventory.ReadData(filepath);
                        inventory.DisplayData(name);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 3");
                        break;
                }
            }
        }
    }
}
