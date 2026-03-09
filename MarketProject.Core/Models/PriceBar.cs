namespace MarketProject.Core.Models;

public sealed record PriceBar(
    DateTime Time,
    double Open,
    double High,
    double Low,
    double Close,
    double Volume
);