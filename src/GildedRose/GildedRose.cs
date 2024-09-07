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
                    item.Quality += (item.SellIn < 0 ? 2 : 1);
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    switch (item.SellIn)
                    {
                        case < 0:
                            item.Quality = 0;
                            break;
                        case < 5:
                            item.Quality += 3;
                            break;
                        case < 10:
                            item.Quality += 2;
                            break;
                        default:
                            item.Quality++;
                            break;
                    }
                }
                else
                {
                    item.Quality -= (item.SellIn < 0 ? 2 : 1);
                }

                item.Quality = item.Quality switch
                {
                    < 0 => 0,
                    > 50 => 50,
                    _ => item.Quality
                };
            }
        }
    }
}
