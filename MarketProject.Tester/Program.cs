using MarketProject.Core.Calculations;
using MarketProject.Core.Models;
using MarketProject.Core.Types;
using MarketProject.Core.Calculations.Interest;

var rate = new InterestRate(
    0.12m,
    CompoundingType.Discrete,
    12);

var efectiveAnnualRate = rate.EffectiveAnnualRate();
Console.WriteLine($"Effective Annual Rate: {efectiveAnnualRate:P2}");

var result = FutureValue.CalculateFutureValue(
    100m,
    rate,
    1);
Console.WriteLine($"Future Value: {result}");  