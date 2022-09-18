using System;

namespace New_Year_s_gift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cracker1 = new Cracker(
                name: "TuC",
                weight: new Weight(value: 21, measure: Measure.Gr),
                price: new Price(value: 23.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 4.935, proteins: 1.575, carbs: 13.335),
                manufacturer: new Manufacturer(companyName: "Джури Кекс КФТ", importer: "ЗАО «Крафт Фудз Украина»", country: Country.Ukraine),
                sugarAmount: 5.0,
                flour: Flour.Wheat,
                dough: Dough.Puff,
                flavorAdditive: FlavorAdditive.Bacon);

            var cracker2 = new Cracker(
                name: "TuC",
                weight: new Weight(value: 21, measure: Measure.Gr),
                price: new Price(value: 23.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 4.935, proteins: 1.575, carbs: 13.335),
                manufacturer: new Manufacturer(companyName: "Джури Кекс КФТ", importer: "ЗАО «Крафт Фудз Украина»", country: Country.Ukraine),
                sugarAmount: 5.0,
                flour: Flour.Wheat,
                dough: Dough.Puff,
                flavorAdditive: FlavorAdditive.Cheese);

            var jellyMarmalade = new JellyMarmalade(
                name: "Jelly Bears",
                weight: new Weight(value: 210, measure: Measure.Gr),
                price: new Price(value: 48.5M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 1.001, proteins: 14.142, carbs: 154.095),
                manufacturer: new Manufacturer(companyName: "Haribo", importer: "ЗАО «Крафт Фудз Украина»", country: Country.Ukraine),
                sugarAmount: 154.0,
                thickener: Thickener.Gelatin,
                form: TypeOfForm.Bear,
                flavorAdditive: FlavorAdditive.Orange,
                color: ConsoleColor.Green);

            Console.WriteLine(jellyMarmalade.GetCaloricValue());
        }
    }
}
