using GildedRose.Decorators;
using GildedRoseKata;

namespace GildedRose.Items
{
    public class AgedBrieItem : ItemDecorator
    {
        public AgedBrieItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// Gets the quality adjustment for Aged Brie items.
        /// </summary>
        /// <param name="sellIn">Sell in days left.</param>
        /// <returns>Returns 1 if sell in days is greater than 0; otherwise 2.</returns>
        protected override int GetQualityAdjustment(int sellIn)
        {
            return sellIn > 0 ? 1 : 2;
        }
    }
}
