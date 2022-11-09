using System.Collections.Generic;
using TradeCategory.Risk;
using TradeCategory.Risks;
using TradeCategory.Trades;

namespace TradeCategory.Categories
{
    public class Category
    {
        private List<ITrade> portfolio;

        public Category(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                RiskBase.Create(TypeRisk.Expired),
                RiskBase.Create(TypeRisk.MediumRisk),
                RiskBase.Create(TypeRisk.HighRisk)
            };

            foreach (Trade trade in portfolio)
            {
                foreach (IRisk r in risks)
                {
                    risk = r;

                    if (trade.CalculateRisk(r))
                        break;
                }

                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
