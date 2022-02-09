using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Stockmanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stocksmanagement stocks = new Stocksmanagement();
            stocks.Stocks(@"C:\bridgelabz\OOPS\UC3_Stockmanagement\UC3_Stockmanagement\Stocks.json");
            Console.ReadLine();
        }
    }
}
