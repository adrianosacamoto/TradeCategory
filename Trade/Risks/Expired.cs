using TradeCategory.Risk;
using TradeCategory.Trades;

namespace TradeCategory.Risks
{
    public class Expired : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (PaymentDateLateByMoreThanThirtyDays(trade))
            {
                this.Type = TypeRisk.Expired.ToString().ToUpper();

                return true;
            }

            this.Type = TypeRisk.Nonerisk.ToString().ToUpper();

            return false;
        }

        private bool PaymentDateLateByMoreThanThirtyDays(ITrade trade)
        {
            var diferenceInDays = trade.ReferenceDate.Subtract(trade.NextPaymentDate).Days;
            return diferenceInDays > 30;
        }
    }
}
