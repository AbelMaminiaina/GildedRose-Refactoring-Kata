namespace GildedRoseKata.Strategies;

public class NormalItemStrategy : BaseItemStrategy
{
    public override void Update(Item item)
    {
        DecreaseSellIn(item);
        DecreaseQuality(item, IsExpired(item) ? 2 : 1);
    }
}
