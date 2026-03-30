using System;
using MarketProject.Core.Calculations.Interest;
using MarketProject.Core.Types;
namespace MarketProject.Core.Calculations.CashFlows;

public static class NetPresentValue
{
    public static decimal Calculate(
        InterestRate rate,
        IEnumerable<ValueAnchor> cashFlows,
        EffectiveAnualRate ear,
        double targetTime = 0.0 // por default NPV en t=0
        ) 
    {
        decimal npv = 0m;

        foreach (var cf in cashFlows)
        {
            npv += TimeValueEngine.Transport(rate, cf, targetTime, ear);
        }

        return npv;
    }
}