using GildedRoseKata;

namespace GildedRose.Items
{
    public class ConjuredItem : ItemUpdatable
    {
        public ConjuredItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// Gets the quality adjustment for Conjured items.
        /// </summary>
        /// <param name="sellIn">Sell in days left.</param>
        /// <returns>Returns -2 if sell in days is greater than 0; otherwise -4.</returns>
        protected override int GetQualityAdjustment(int sellIn)
        {
            return sellIn > 0 ? -2 : -4;
        }
    }
}
