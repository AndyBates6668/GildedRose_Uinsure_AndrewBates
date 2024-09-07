using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public const string AgedBrie = "Aged Brie";
        public const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        public const string Conjured = "Conjured Mana Cake";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";

        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name == "Sulfuras, Hand of Ragnaros") continue;

                item.SellIn--;

                if (item.Name == "Aged Brie")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;
                    }
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.SellIn < 10)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality++;
                            }

                            if (item.SellIn < 5)
                            {
                                if (item.Quality < 50)
                                {
                                    item.Quality++;
                                }
                            }
                        }
                    }
                }
                else if (item.Quality > 0)
                {
                    item.Quality--;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name == "Aged Brie")
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                    else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = 0;
                    }
                    else if (item.Quality > 0)
                    {
                        item.Quality--;
                    }
                }
            }
        }
    }
}
