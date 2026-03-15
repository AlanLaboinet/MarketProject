using System;
namespace MarketProject.Core.Types;


public class InterestRate
{

    public decimal Value { get; }
    public CompoundingType Compounding { get; }
    public int Frequency { get; }

    public InterestRate(decimal value, CompoundingType compounding, int frequency = 1)
    {
        Value = value;
        Compounding = compounding;
        Frequency = frequency;
    }
}