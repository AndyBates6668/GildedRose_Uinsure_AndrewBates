using GildedRose.Interfaces;
using GildedRoseKata;

namespace GildedRose.Decorators
{
    /// <summary>
    /// Decorator for item to allow containment of the existing Item and extension by adding new methods to the decorator.
    /// </summary>
    public class ItemDecorator : IItemDecorator
    {
        public Item Item { get; protected set; }

        /// <summary>
        /// Store the contained Item.
        /// </summary>
        /// <param name="item">Item being contained.</param>
        public ItemDecorator(Item item)
        {
            Item = item;
        }
    }
}
