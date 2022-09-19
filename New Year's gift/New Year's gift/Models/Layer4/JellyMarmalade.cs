using System;

namespace New_Year_s_gift
{
    public class JellyMarmalade : Marmalade
    {
        public JellyMarmalade(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, Thickener thickener, TypeOfForm form, FlavorAdditive flavorAdditive, ConsoleColor color)
        : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, thickener, form, color)
        {
            FlavorAdditive = flavorAdditive;
        }

        public FlavorAdditive FlavorAdditive { get; init; }
    }
}
