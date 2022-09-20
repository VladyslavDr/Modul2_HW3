using System;

namespace New_Year_s_gift
{
    public class Lollipop : Caramel
    {
        public Lollipop(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, TypeOfForm form, FlavorAdditive flavorAdditive, ConsoleColor color, CandyWrapper candyWrapper)
            : base(name, weight, price, nutritionalvalue,  manufacturer, sugarAmount, form, candyWrapper, color, flavorAdditive)
        {
        }
    }
}
