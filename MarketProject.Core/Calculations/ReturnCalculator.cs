namespace MarketProject.Core.Calculations;


public static class ReturnCalculator
{
    public static IEnumerable<double> LogReturns(IReadOnlyList<double> prices)
    {
        for (int i = 1; i < prices.Count; i++)
        {
            yield return Math.Log(prices[i] / prices[i - 1]);
        }
    }
}