using System;
using MarketProject.Core.Calculations.Interest;
using MarketProject.Core.Types;

namespace MarketProject.Core.Calculations.CashFlows;

public static class TimeValueEngine
{
    public static decimal Transport(
        InterestRate rate,
        ValueAnchor anchor,
        double targetTime,
        EffectiveAnualRate ear)
    {
        double deltaT = targetTime - anchor.Time;

        decimal growthFactor = (decimal)Math.Pow(1 + (double)ear.Calculate(rate), deltaT);

        return anchor.Value * growthFactor;
    }

    

}
