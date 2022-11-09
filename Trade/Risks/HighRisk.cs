using TradeCategory.Enums;
using TradeCategory.Risk;
using TradeCategory.Trades;

namespace TradeCategory.Risks
{
    public class HighRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals(SectorRisk.Private.ToString()))
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }

            this.Type = TypeRisk.Nonerisk.ToString().ToUpper();

            return false;
        }
    }
}
