using System;

namespace MarketProject.Core.Calculations.CashFlows;

public class ValueAnchor
{
    public decimal Value { get; }
    public double Time { get; } // en años

    public ValueAnchor(decimal value, double time)
    {
        Value = value;
        Time = time;
    }
}