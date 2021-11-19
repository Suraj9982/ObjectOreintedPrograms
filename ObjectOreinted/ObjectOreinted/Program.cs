using System;

namespace ObjectOreinted
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION:\n1.Display\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inventory = new InventoryMain();
                        string filepath = @"C:\Users\admin\Desktop\github\ObjectOreintedPrograms\ObjectOreinted\ObjectOreinted\Files\json1.json";
                        inventory.DisplayData(filepath);
                        break;
                    case 2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 2");
                        break;
                }
            }
        }
    }
}
