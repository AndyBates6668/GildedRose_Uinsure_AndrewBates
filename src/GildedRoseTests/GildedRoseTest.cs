using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Theory]
        [InlineData(-1, 0, 2)] // Quality increases by 2.
        [InlineData(-1, 50, 50)] // Quality remains same.
        [InlineData(0, 25, 27)] // Quality increases by 2.
        [InlineData(1, 25, 26)] // Quality increases by 1.
        public void GildedRose_AgedBrieItem_Tests(int sellIn, int quality, int expectedQuality)
        {
            int actualQuality = CreateItemsAndUpdateQuality(GildedRoseKata.GildedRose.AgedBrie, sellIn, quality);
            Assert.Equal(expectedQuality, actualQuality);
        }

        [Theory]
        [InlineData(0, 25, 0)] // Quality becomes 0.
        [InlineData(5, 25, 28)] // Quality increases by 3.
        [InlineData(10, 25, 27)] // Quality increases by 2.
        [InlineData(15, 25, 26)] // Quality increases by 1.
        public void GildedRose_BackstagePassItem_Tests(int sellIn, int quality, int expectedQuality)
        {
            int actualQuality = CreateItemsAndUpdateQuality(GildedRoseKata.GildedRose.BackstagePass, sellIn, quality);
            Assert.Equal(expectedQuality, actualQuality);
        }

        [Theory]
        [InlineData(-1, 25, 21)] // Quality decreases by 4.
        [InlineData(0, 25, 21)] // Quality decreases by 4.
        [InlineData(1, 25, 23)] // Quality decreases by 2.
        public void GildedRose_ConjuredItem_Tests(int sellIn, int quality, int expectedQuality)
        {
            int actualQuality = CreateItemsAndUpdateQuality(GildedRoseKata.GildedRose.Conjured, sellIn, quality);
            Assert.Equal(expectedQuality, actualQuality);
        }

        [Theory]
        [InlineData(-1, 25, 23)] // Quality decreases by 2.
        [InlineData(0, 25, 23)] // Quality decreases by 2.
        [InlineData(1, 25, 24)] // Quality decreases by 1.
        public void GildedRose_NormalItem_Tests(int sellIn, int quality, int expectedQuality)
        {
            int actualQuality = CreateItemsAndUpdateQuality("Normal Item", sellIn, quality);
            Assert.Equal(expectedQuality, actualQuality);
        }

        [Theory]
        [InlineData(-1, 80, 80)] // Quality remains same.
        [InlineData(0, 80, 80)] // Quality remains same.
        [InlineData(1, 80, 80)] // Quality remains same.
        public void GildedRose_SulfuraItem_Tests(int sellIn, int quality, int expectedQuality)
        {
            int actualQuality = CreateItemsAndUpdateQuality(GildedRoseKata.GildedRose.Sulfuras, sellIn, quality);
            Assert.Equal(expectedQuality, actualQuality);
        }

        /// <summary>
        /// Create an items list for the provided item and call UpdateQuality for it.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        /// <param name="sellIn">Sell in of the item.</param>
        /// <param name="quality">Quality of the item.</param>
        /// <returns>The updated quality of the provided item.</returns>
        private int CreateItemsAndUpdateQuality(string name, int sellIn, int quality)
        {
            IList<Item> Items = [new Item { Name = name, SellIn = sellIn, Quality = quality }];
            var app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQuality();
            return Items[0].Quality;
        }
    }
}
