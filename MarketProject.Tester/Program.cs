using MarketProject.Core.Calculations;
using MarketProject.Core.Models;

var prices = new List<double> { 100, 105, 110, 120 };

var returns = ReturnCalculator.LogReturns(prices);

foreach (var r in returns)
{
    Console.WriteLine(r);
}