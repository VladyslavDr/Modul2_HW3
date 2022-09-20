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
        : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, flour, dough)
        {
            FlavorAdditive = flavorAdditive;
        }

        public FlavorAdditive FlavorAdditive { get; init; }
    }
}
