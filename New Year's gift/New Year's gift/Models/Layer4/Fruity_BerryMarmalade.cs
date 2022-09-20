using System;

namespace New_Year_s_gift
{
    public class Fruity_BerryMarmalade : Marmalade
    {
        public Fruity_BerryMarmalade(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, Thickener thickener, TypeOfForm form, Fruit fruit, ConsoleColor color)
            : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, thickener, form, color)
        {
            Fruit = fruit;
        }

        public Fruit Fruit { get; init; }
    }
}
