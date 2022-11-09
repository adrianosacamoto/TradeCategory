using System;
using TradeCategory.Risk;

namespace TradeCategory.Risks
{
    public class RiskBase
    {
        public static IRisk Create(TypeRisk risk)
        {
            switch (risk)
            {
                case TypeRisk.Expired:
                    return new Expired();
                case TypeRisk.MediumRisk:
                    return new MediumRisk();
                case TypeRisk.HighRisk:
                    return new HighRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
