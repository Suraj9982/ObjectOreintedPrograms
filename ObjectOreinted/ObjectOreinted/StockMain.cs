using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectOreinted
{
    class StockMain
    {
        public void DisplayStockData(string stockfilepath)
        {
            try
            {
                using (StreamReader r = new StreamReader(stockfilepath))
                {
                    var json = r.ReadToEnd();
                    var stocklist = JsonConvert.DeserializeObject<List<StockModel>>(json);
                    Console.WriteLine("CompanyName\tNo.of Stocks\tStockPrice\tTotalValue");
                    foreach (var stock in stocklist)
                    {
                        Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", stock.stockname, stock.stocknumber, stock.stockprice, stock.stocknumber * stock.stockprice);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
