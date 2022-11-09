using System;

namespace TradeCategory.Trades
{
    public interface ITrade
    {
        DateTime ReferenceDate { get; set; }
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
    }
}
