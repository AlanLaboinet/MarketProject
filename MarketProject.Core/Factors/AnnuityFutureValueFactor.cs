using System;
using MarketProject.Core.Calculations.Interest;
using MarketProject.Core.Types;

namespace MarketProject.Core.Calculations.Factors;

public static class AnnuityFutureValueFactor
{
    public static decimal Calculate(InterestRate rate, int years)
    {
        
        double r = (double)rate.Rate;
        double t = years;
        
       switch (rate.Compounding)
        {
            
            case CompoundingType.Simple:
                return (decimal)(t * (1 + r * (t - 1) / 2));

            case CompoundingType.Discrete:
                return (GrowthFactor.Calculate(rate, years) - 1) / (decimal)r;  

            case CompoundingType.Continuous:
                return (GrowthFactor.Calculate(rate, years) - 1) / (decimal)r;     

            default:
                throw new ArgumentOutOfRangeException(nameof(rate.Compounding), "Unsupported compounding type.");

        }
    }
}
