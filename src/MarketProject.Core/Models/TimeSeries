namespace MarketProject.Core.Models;

public sealed class TimeSeries
{
    public IReadOnlyList<PriceBar> Bars { get; }

    public TimeSeries(IEnumerable<PriceBar> bars)
    {
        Bars = bars
            .OrderBy(b => b.Time)
            .ToList()
            .AsReadOnly();
    }

    public IEnumerable<double> ClosePrices =>
        Bars.Select(b => b.Close);
}