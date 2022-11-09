using System;

namespace TradeCategory.Trades
{
    public interface ITrade
    {
        DateTime ReferenceDate { get; }
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}
