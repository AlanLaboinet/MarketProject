using System;
namespace MarketProject.Core.Types;


public class InterestRate
{

    public decimal Rate { get; }
    public CompoundingType Compounding { get; }
    public int Frequency { get; }

    public InterestRate(decimal rate, CompoundingType compounding, int frequency = 1)
    {
        Rate = rate;
        Compounding = compounding;
        Frequency = frequency;
    }

        public decimal EffectiveAnnualRate(){
        
        double r = (double)Rate;

        switch (Compounding)
        {
            case CompoundingType.Simple:
                return Rate;

            case CompoundingType.Discrete:

                if (Frequency <= 0)
                    throw new InvalidOperationException("Frequency must be greater than zero.");

                return (decimal)Math.Pow(1 + r / Frequency, Frequency) - 1;

            case CompoundingType.Continuous:
                return (decimal)Math.Exp(r) - 1;

            default:
                throw new NotSupportedException($"Compounding type {Compounding} not supported.");
        }
    }

}