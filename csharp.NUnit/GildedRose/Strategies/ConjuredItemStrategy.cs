namespace GildedRoseKata.Strategies;

public class ConjuredItemStrategy : BaseItemStrategy
{
    public override void Update(Item item)
    {
        DecreaseSellIn(item);
        // Conjured se dégrade 2x plus vite qu'un article normal
        DecreaseQuality(item, IsExpired(item) ? 4 : 2);
    }
}
