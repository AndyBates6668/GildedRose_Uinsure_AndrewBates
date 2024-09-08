using GildedRoseKata;

namespace GildedRose.Items
{
    public class NormalItem : ItemUpdatable
    {
        public NormalItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// Gets the quality adjustment for Normal items.
        /// </summary>
        /// <param name="sellIn">Sell in days left.</param>
        /// <returns>Returns -1 if sell in days is greater than 0; otherwise -2.</returns>
        protected override int GetQualityAdjustment(int sellIn)
        {
            return sellIn > 0 ? -1 : -2;
        }
    }
}
