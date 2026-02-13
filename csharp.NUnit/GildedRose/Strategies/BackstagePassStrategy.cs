namespace GildedRoseKata.Strategies;

public class BackstagePassStrategy : BaseItemStrategy
{
    public override void Update(Item item)
    {
        DecreaseSellIn(item);

        if (IsExpired(item))
        {
            item.Quality = 0;
        }
        else if (item.SellIn < 5)
        {
            IncreaseQuality(item, 3);
        }
        else if (item.SellIn < 10)
        {
            IncreaseQuality(item, 2);
        }
        else
        {
            IncreaseQuality(item, 1);
        }
    }
}
