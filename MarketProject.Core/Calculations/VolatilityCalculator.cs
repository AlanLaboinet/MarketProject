using MarketProject.Core.Statistics;

namespace MarketProject.Core.Calculations;

public static class VolatilityCalculator
{
    public static double AnnualizedVolatility(
        IEnumerable<double> returns,
        int periodsPerYear)
    {
        double sigma = DescriptiveStatistics.StandardDeviation(returns);
        return sigma * Math.Sqrt(periodsPerYear);
    }
}