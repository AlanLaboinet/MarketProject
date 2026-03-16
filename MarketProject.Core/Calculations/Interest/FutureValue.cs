using System;
using MarketProject.Core.Types;

namespace MarketProject.Core.Calculations.Interest;

public static class FutureValue
{

    public static decimal CalculateFutureValue(
    decimal presentValue,
    InterestRate rate,
    decimal time){
    return rate.Compounding switch
    {
        CompoundingType.Simple =>
            presentValue * (1 + rate.Rate * time),

        CompoundingType.Discrete =>
            presentValue *
            (decimal)Math.Pow(
                (double)(1 + rate.Rate / rate.Frequency),
                (double)(rate.Frequency * time)
            ),

        CompoundingType.Continuous =>
            presentValue *
            (decimal)Math.Exp((double)(rate.Rate * time)),

        _ => throw new ArgumentException("Invalid compounding type")
    };
}   
}
