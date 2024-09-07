using GildedRose.Decorators;
using GildedRose.Items;
using GildedRoseKata;

namespace GildedRose.Factories
{
    /// <summary>
    /// Factory class to construct specific decorated items for the different items.
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Constructs a decorated version of the supplied item.
        /// </summary>
        /// <param name="item">Item to contain.</param>
        /// <returns>The decorated item class.</returns>
        public static ItemDecorator CreateItem(Item item)
        {
            switch (item.Name)
            {
                case GildedRoseKata.GildedRose.AgedBrie:
                    return new AgedBrieItem(item);
                case GildedRoseKata.GildedRose.BackstagePass:
                    return new BackstagePassItem(item);
                case GildedRoseKata.GildedRose.Conjured:
                    return new ConjuredItem(item);
                case GildedRoseKata.GildedRose.Sulfuras:
                    return new SulfuraItem(item);
                default:
                    return new NormalItem(item);
            }
        }
    }
}
