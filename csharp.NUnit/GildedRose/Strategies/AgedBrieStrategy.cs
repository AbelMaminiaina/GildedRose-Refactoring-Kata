namespace GildedRoseKata.Strategies;

public class AgedBrieStrategy : BaseItemStrategy
{
    public override void Update(Item item)
    {
        DecreaseSellIn(item);
        IncreaseQuality(item, IsExpired(item) ? 2 : 1);
    }
}
