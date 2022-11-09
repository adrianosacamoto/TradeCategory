using TradeCategory.Trades;

namespace TradeCategory.Risks
{
    public interface IRisk
    {
        string Type { get; }

        bool CalculateRisk(ITrade trade);
    }
}
