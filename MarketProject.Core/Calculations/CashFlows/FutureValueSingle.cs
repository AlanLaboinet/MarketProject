using System;
using MarketProject.Core.Types;
using MarketProject.Core.Calculations.Factors;
namespace MarketProject.Core.Calculations.CashFlows;

public static class FutureValueSingle
{

    public static decimal Calculate(
    decimal presentValue,
    InterestRate rate,
    int years){
    return rate.Compounding switch
    {
        CompoundingType.Simple =>
            presentValue * GrowthFactor.Calculate(rate, years),

        CompoundingType.Discrete =>
            presentValue * GrowthFactor.Calculate(rate, years),

        CompoundingType.Continuous =>
            presentValue * GrowthFactor.Calculate(rate, years),
            
        _ => throw new ArgumentException("Invalid compounding type")
    };
}   
}