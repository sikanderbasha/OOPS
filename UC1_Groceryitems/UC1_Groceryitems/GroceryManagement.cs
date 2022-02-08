using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Groceryitems
{
    public class GroceryManagement
    {
        public void ReadData(string filepath)
        {
            try
            {
                // var json = JsonConvert.DeserializeObject<Inventory>(filepath);
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Grocery>>(json);
                    Console.WriteLine("name\t" + "price\t" + "weight\t" + "total amount");
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight + "\t" + item.Price * item.Weight);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
