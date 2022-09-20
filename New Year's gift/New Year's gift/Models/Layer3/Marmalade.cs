using System;

namespace New_Year_s_gift
{
    public class Marmalade : SugarProduct
    {
        public Marmalade(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, Thickener thickener, TypeOfForm form, ConsoleColor color)
        {
            Name = name;
            Weight = new Weight(weight.Value, weight.Measure);
            Price = new Price(price.Value, price.Currency);
            NutritionalValue = new NutritionalValue(
                proteins: nutritionalvalue.Proteins,
                fats: nutritionalvalue.Fats,
                carbs: nutritionalvalue.Carbs);
            Manufacturer = new Manufacturer(
                companyName: manufacturer.CompanyName,
                importer: manufacturer.Importer,
                country: manufacturer.Country);
            SugarAmount = sugarAmount;
            Thickener = thickener;
            Form = form;
            Color = color;
        }

        public Thickener Thickener { get; init; }
        public ConsoleColor Color { get; init; }
    }
}
