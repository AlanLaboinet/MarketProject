using MarketProject.Core.Types;
using MarketProject.Core.Calculations.CashFlows;
using MarketProject.Core.Calculations.Interest;
using MarketProject.Core.Calculations.Factors;



var rate = new InterestRate(
    rate:0.12m,
    CompoundingType.Discrete,
    periods: 365);

var efectiveAnnualRate = new EffectiveAnualRate().Calculate(rate); ;
Console.WriteLine($"Effective Annual Rate: {efectiveAnnualRate:P2}");

var result = FutureValueSingle.Calculate(
    5000m,
    rate,
    10);
Console.WriteLine($"Future Value: {result}");  

var valueEngine= TimeValueEngine.Transport(
    rate,
    new ValueAnchor(10000m, 1),
    0,
    new EffectiveAnualRate());

Console.WriteLine($"Present Value with TimeValueEngine: {valueEngine}");


var cashFlows = new List<ValueAnchor>
{
    new ValueAnchor(-1000m, 0), // inversión inicial
    new ValueAnchor(300m, 1),
    new ValueAnchor(400m, 2),
    new ValueAnchor(500m, 3)
};

var npv = NetPresentValue.Calculate(rate,cashFlows, new EffectiveAnualRate(), targetTime: 0);

Console.WriteLine($"The net present value is: {npv}");