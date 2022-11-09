using System;
using System.Collections.Generic;
using TradeCategory.Categories;
using TradeCategory.Trades;

namespace TradeCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrade> portfolio;
            List<string> tradeCategories;

            DateTime referenceDate = new DateTime(2020, 12, 11);

            Trade trade1 = new Trade(referenceDate) { Value = 2000000, ClientSector = "Private", NextPaymentDate = new DateTime(2025, 12, 29).Date };
            Trade trade2 = new Trade(referenceDate) { Value = 400000, ClientSector = "Public", NextPaymentDate = new DateTime(2020, 07, 01).Date };
            Trade trade3 = new Trade(referenceDate) { Value = 5000000, ClientSector = "Public", NextPaymentDate = new DateTime(2024, 01, 02).Date };
            Trade trade4 = new Trade(referenceDate) { Value = 3000000, ClientSector = "Public", NextPaymentDate = new DateTime(2023, 10, 26).Date };

            portfolio = new List<ITrade> { trade1, trade2, trade3, trade4 };

            tradeCategories = new Category(portfolio).GetCategories();

            Console.WriteLine("Input:");
            Console.WriteLine("{0}", referenceDate.ToString("MM/dd/yyyy"));
            Console.WriteLine("{0}", portfolio.Count);
            foreach (ITrade trade in portfolio)
            {
                Console.WriteLine("{0} {1} {2}", trade.Value, trade.ClientSector, trade.NextPaymentDate.ToString("MM/dd/yyyy"));
            }
            Console.WriteLine("\nOutput:");
            Console.WriteLine("{0} \n{1} \n{2} \n{3}", tradeCategories[0], tradeCategories[1], tradeCategories[2], tradeCategories[3]);
            Console.Write("\n\nPress any key to finish...");
            Console.ReadKey();
        }
    }
}
