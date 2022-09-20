using System;

namespace New_Year_s_gift
{
    public class Caramel : Candy
    {
        public Caramel(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, TypeOfForm form, CandyWrapper candyWrapper, ConsoleColor color, FlavorAdditive flavorAdditive)
           : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, form, candyWrapper)
        {
            Color = color;
            FlavorAdditive = flavorAdditive;
        }

        public ConsoleColor Color { get; init; }
        public FlavorAdditive FlavorAdditive { get; init; }
    }
}
