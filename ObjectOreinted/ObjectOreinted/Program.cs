using System;

namespace ObjectOreinted
{
    class Program
    {
        static string filepath = @"C:\Users\admin\Desktop\github\ObjectOreintedPrograms\ObjectOreinted\ObjectOreinted\Files\InventoryList.json";
        static string stockfilepath = @"C:\Users\admin\Desktop\github\ObjectOreintedPrograms\ObjectOreinted\ObjectOreinted\Files\Stocklist.json";
        static void Main(string[] args)
        {
            InventoryMain inventory = new InventoryMain();
            StockMain stocklist = new StockMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Read Inventory list\n2.Display Inventory list\n3.Display Stock list\n4.Exit");
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
                        stocklist.DisplayStockData(stockfilepath);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 4");
                        break;
                }
            }
        }
    }
}
