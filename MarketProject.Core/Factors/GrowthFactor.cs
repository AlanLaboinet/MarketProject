using System;
using MarketProject.Core.Types;

namespace MarketProject.Core.Calculations.Factors;

public class GrowthFactor
{
     public static decimal Calculate(InterestRate rate, int years)
    {
        
        double r = (double)rate.Rate;
        double t = years;
        double m = (double)rate.Periods;

        return rate.Compounding switch
        {

        CompoundingType.Simple => (decimal)(1 + r * t),

        CompoundingType.Discrete =>
        (decimal)Math.Pow(1 + r/m, t*m),

        CompoundingType.Continuous =>
        (decimal)Math.Exp(r * t),

        _ => throw new NotSupportedException($"Compounding type {rate.Compounding} not supported.")
    };      
      

    }
}
