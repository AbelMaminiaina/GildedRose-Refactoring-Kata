namespace GildedRoseKata.Strategies;

public static class ItemStrategyFactory
{
    public static IItemStrategy Create(Item item) => item.Name switch
    {
        "Aged Brie" => new AgedBrieStrategy(),
        "Sulfuras, Hand of Ragnaros" => new SulfurasStrategy(),
        var name when name.StartsWith("Backstage passes") => new BackstagePassStrategy(),
        var name when name.StartsWith("Conjured") => new ConjuredItemStrategy(),
        _ => new NormalItemStrategy()
    };
}
