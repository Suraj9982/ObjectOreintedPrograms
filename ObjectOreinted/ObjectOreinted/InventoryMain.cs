using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectOreinted
{
    class InventoryMain
    {
        List<InventoryModel> ricelist;
        List<InventoryModel> wheatlist;
        List<InventoryModel> pulseslist;

        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(filepath))
                {
                    var json = r.ReadToEnd();
                    InventoryFactory item = JsonConvert.DeserializeObject<InventoryFactory>(json);
                    ricelist = item.Rice;
                    wheatlist = item.Wheat;
                    pulseslist = item.Pulses;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayData(string state)
        {
            if (state == "rice".ToLower())
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var items in ricelist)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", items.Name, items.Weight, items.Price);
                }
            }
            if (state == "Wheat".ToLower())
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var items in wheatlist)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", items.Name, items.Weight, items.Price);
                }
            }
            if (state == "pulse".ToLower())
            {
                Console.WriteLine("Name\tWeight\tPrice");
                foreach (var items in pulseslist)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}", items.Name, items.Weight, items.Price);
                }
            }
        }
    }
}
