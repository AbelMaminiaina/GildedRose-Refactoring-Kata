using System;

namespace GildedRoseKata.Strategies;

public abstract class BaseItemStrategy : IItemStrategy
{
    protected const int MaxQuality = 50;
    protected const int MinQuality = 0;

    public abstract void Update(Item item);

    protected void IncreaseQuality(Item item, int amount = 1)
    {
        item.Quality = Math.Min(item.Quality + amount, MaxQuality);
    }

    protected void DecreaseQuality(Item item, int amount = 1)
    {
        item.Quality = Math.Max(item.Quality - amount, MinQuality);
    }

    protected void DecreaseSellIn(Item item)
    {
        item.SellIn--;
    }

    protected bool IsExpired(Item item) => item.SellIn < 0;
}
