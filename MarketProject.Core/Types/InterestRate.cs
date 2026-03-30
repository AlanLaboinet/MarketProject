using System;
namespace MarketProject.Core.Types;


public class InterestRate
{

    public decimal Rate { get; }
    public CompoundingType Compounding { get; }

    public int Periods { get; }
    public InterestRate(decimal rate, CompoundingType compounding, int periods = 1)
    {
        //This can be apr, continous or any else        
        Rate = rate;
        
        Compounding = compounding;

        //This is always periods per year
        Periods = periods;
    }

}
