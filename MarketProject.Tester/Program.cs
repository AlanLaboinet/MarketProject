using MarketProject.Core.Calculations;
using MarketProject.Core.Models;
using MarketProject.Core.Types;
using MarketProject.Core.Calculations.Interest;

var rate = new InterestRate(
    0.06m,
    CompoundingType.Discrete,
    2);

var result = FutureValue.CalculateFutureValue(
    1000,
    rate,
    1);
Console.WriteLine($"Future Value: {result}");  