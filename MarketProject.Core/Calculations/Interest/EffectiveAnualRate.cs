using System;
using MarketProject.Core.Types;
namespace MarketProject.Core.Calculations.Interest;

public class EffectiveAnualRate
{
    public  decimal Calculate(InterestRate rate){
        
        double r = (double)rate.Rate;
        double m = (double)rate.Periods;

        switch (rate.Compounding)
        {
            case CompoundingType.Simple:
                return (decimal)r;

            case CompoundingType.Discrete:

                if (m <= 0)
                    throw new InvalidOperationException("Periods must be greater than zero.");

                return (decimal)Math.Pow(1 +  r / m, m) - 1;

            case CompoundingType.Continuous:
                return (decimal)Math.Exp(r) - 1;

            default:
                throw new NotSupportedException($"Compounding type {rate.Compounding} not supported.");
        }
    }
}
