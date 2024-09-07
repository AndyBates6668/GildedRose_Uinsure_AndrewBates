using GildedRoseKata;

namespace GildedRose.Decorators
{
    /// <summary>
    /// Decorator for item to allow containment of the existing Item and extension by adding new methods to the decorator.
    /// </summary>
    public abstract class ItemDecorator
    {
        public const int QualityMinimum = 0;
        public const int QualityMaximum = 50;

        protected Item Item;

        /// <summary>
        /// Store the contained Item.
        /// </summary>
        /// <param name="item">Item being contained.</param>
        public ItemDecorator(Item item)
        {
            Item = item;
        }

        /// <summary>
        /// Update the items quality calling the GetQualityAdjustment abstract method for each item.
        /// </summary>
        public void UpdateQuality()
        {
            // Get the quality adjustment for the item based on the sell in days.
            var qualityAdjustment = GetQualityAdjustment(Item.SellIn);

            // Did we get an adjustment value?
            if (qualityAdjustment != 0)
            {
                // Calculate the new quality.
                var quality = Item.Quality + qualityAdjustment;

                // Ensure that the quality doesn't go below or above the minimum or maximum.
                if (quality < QualityMinimum) quality = QualityMinimum;
                if (quality > QualityMaximum) quality = QualityMaximum;

                // Set the new quality value.
                Item.Quality = quality;
            }
        }

        /// <summary>
        /// Gets the quality adjustment in the form of a positive or negative number to
        /// adjust the current quality by. If 0 is returned then no adjustment is made.
        /// </summary>
        /// <param name="sellIn">Sell in days remaining for the item.</param>
        /// <returns></returns>
        protected abstract int GetQualityAdjustment(int sellIn);
    }
}
