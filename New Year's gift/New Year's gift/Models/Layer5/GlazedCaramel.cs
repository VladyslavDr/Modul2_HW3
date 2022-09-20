using System;
namespace New_Year_s_gift
{
    public class GlazedCaramel : Caramel
    {
        public GlazedCaramel(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, TypeOfForm form, FlavorAdditive flavorAdditive, ConsoleColor color, CandyWrapper candyWrapper, Glaze glaze)
            : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, form, candyWrapper, color, flavorAdditive)
        {
            Glaze = glaze;
        }

        public Glaze Glaze { get; init; }
    }
}
