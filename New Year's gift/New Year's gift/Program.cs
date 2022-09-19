using System;

namespace New_Year_s_gift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var catalog = Catalog.GetInstance();

            var myGift = new Gift();

            myGift.ShowGift();
            myGift.AddItem(catalog.Sweetness[1]);
            myGift.AddItem(catalog.Sweetness[5]);
            myGift.AddItem(catalog.Sweetness[0]);
            myGift.AddItem(catalog.Sweetness[2]);
            myGift.AddItem(catalog.Sweetness[3]);
            myGift.ShowGift();

            myGift.Sort();

            myGift.ShowItem(name: "toc");
            myGift.ShowItem(new Price(value: 5.99M, Currency.UAH));
            myGift.ShowItem(new Weight(value: 140.0, measure: Measure.Gr));

            Console.WriteLine($"Total weight: {myGift.TotalWeight().Value}{myGift.TotalWeight().Measure}");
        }
    }
}
