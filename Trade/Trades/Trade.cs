using System;
using TradeCategory.Risks;

namespace TradeCategory.Trades
{
    public class Trade : ITrade
    {
        public DateTime ReferenceDate { get; set; }
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }

        public Trade(DateTime referenceDate)
        {
            this.ReferenceDate = referenceDate;
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }
    }
}
