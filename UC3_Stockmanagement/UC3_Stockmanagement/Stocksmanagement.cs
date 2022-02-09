using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UC3_Stockmanagement
{
    internal class Stocksmanagement
    {
        public void Stocks(string FilePath)
        {
            try
            {
                
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    var json = reader.ReadToEnd();
                    var stocksinfo = JsonConvert.DeserializeObject<List<Stocks>>(json);
                    Console.WriteLine("Name\t" + "Quantity\t" + "SharePrice\t" + "Amount per stock\t");
                    int TotalAmount = 0, Price = 0;
                    foreach (var data in stocksinfo)
                    {
                        Price = data.Quantity * data.SharePrice;
                        Console.WriteLine(data.Name + "\t" + data.Quantity + "\t\t" + data.SharePrice + "\t\t" + Price );
                        TotalAmount += data.SharePrice * data.Quantity;
                    }
                    Console.WriteLine("Total Amount :\t" + TotalAmount);


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
