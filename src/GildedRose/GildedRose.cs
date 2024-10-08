﻿using GildedRose.Factories;
using System.Collections.Generic;
using GildedRose.Interfaces;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public const string AgedBrie = "Aged Brie";
        public const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        public const string Conjured = "Conjured Mana Cake";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";

        public const int BackstagePassHighIncrease = 5; // Days before event.
        public const int BackstagePassMediumIncrease = 10; // Days before event.

        private readonly IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                // Create the decorated item.
                var itemDecorated = ItemFactory.CreateItem(item);

                if (itemDecorated is IItemUpdatable itemUpdatable)
                {
                    // Update the items quality.
                    itemUpdatable.UpdateQuality();
                }

                // Decrement the sell in days.
                item.SellIn--;
            }
        }
    }
}
