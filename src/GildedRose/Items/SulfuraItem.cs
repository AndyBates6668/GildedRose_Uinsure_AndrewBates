using GildedRose.Decorators;
using GildedRoseKata;

namespace GildedRose.Items
{
    public class SulfuraItem : ItemDecorator
    {
        public SulfuraItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// Gets the quality adjustment for Sulfuras.
        /// </summary>
        /// <param name="sellIn">Sell in days left.</param>
        /// <returns>Returns 0 for no adjustment.</returns>
        protected override int GetQualityAdjustment(int sellIn)
        {
            return 0;
        }
    }
}
