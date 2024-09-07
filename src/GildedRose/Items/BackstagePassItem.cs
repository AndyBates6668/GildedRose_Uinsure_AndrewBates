using GildedRose.Decorators;
using GildedRoseKata;

namespace GildedRose.Items
{
    public class BackstagePassItem : ItemDecorator
    {
        public BackstagePassItem(Item item) : base(item)
        {
        }

        /// <summary>
        /// Gets the quality adjustment for Backstage Pass.
        /// </summary>
        /// <param name="sellIn">Sell in days left.</param>
        /// <returns>Returns 0 if sell in days is less than or equal to 0, 3 if less than or equal to 5,
        /// 2 if less than or equal to 10; otherwise 1.</returns>
        protected override int GetQualityAdjustment(int sellIn)
        {
            return sellIn switch
            {
                <= 0 => -Item.Quality, // Less than 1 day left then reduce quality by the current quality value; makes it 0.
                <= GildedRoseKata.GildedRose.BackstagePassHighQuality => 3, // High quality so quality increases by 3.
                <= GildedRoseKata.GildedRose.BackstagePassMediumQuality => 2, // Medium quality so quality increases by 2.
                _ => 1 // Default case quality increases by 1.
            };
        }
    }
}
