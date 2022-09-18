using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_s_gift
{
    public class Cracker : Cookies
    {
        public Cracker(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, Flour flour, Dough dough, FlavorAdditive flavorAdditive)
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
            Flour = flour;
            Dough = dough;
            FlavorAdditive = flavorAdditive;
        }

        public FlavorAdditive FlavorAdditive { get; init; }
    }
}
