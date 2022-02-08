using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_Groceryitems
{
    public class Program
    {
        static void Main(string[] args)
        {
            GroceryManagement inventory = new GroceryManagement();
            inventory.ReadData(@"C:\bridgelabz\OOPS\UC1_Groceryitems\UC1_Groceryitems\Grocery.json");
            Console.ReadKey();
        }
    }
}
