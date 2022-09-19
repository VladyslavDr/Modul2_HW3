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

            var jellyMarmalade = new JellyMarmalade(
                name: "Jelly Bears",
                weight: new Weight(value: 210, measure: Measure.Gr),
                price: new Price(value: 48.5M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 1.001, proteins: 14.142, carbs: 154.095),
                manufacturer: new Manufacturer(companyName: "Haribo", importer: "ФИО «I dont know»", country: Country.Germany),
                sugarAmount: 154.0,
                thickener: Thickener.Gelatin,
                form: TypeOfForm.Bear,
                color: ConsoleColor.Green,
                flavorAdditive: FlavorAdditive.Orange);

            var fruity_BerryMarmalade = new Fruity_BerryMarmalade(
                name: "Банановые Червячки",
                weight: new Weight(value: 200, measure: Measure.Gr),
                price: new Price(value: 65.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 0.095, proteins: 11.07, carbs: 135.066),
                manufacturer: new Manufacturer(companyName: "УВлада", importer: "Такси «Болт»", country: Country.Ukraine),
                sugarAmount: 154.0,
                thickener: Thickener.Agar_agar,
                form: TypeOfForm.Warm,
                color: ConsoleColor.Green,
                fruit: Fruit.Banana);

            var carvedGingerbread = new CarvedGingerbread(
                name: "ТУЛЬСКИЙ",
                weight: new Weight(value: 140, measure: Measure.Gr),
                price: new Price(value: 5.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 5.515, proteins: 6.15, carbs: 69.18),
                manufacturer: new Manufacturer(companyName: "ОАО «Тульская кондитерская фабрика «Ясная Поляна»", importer: "fff", country: Country.Russia_Terrorist_Country),
                sugarAmount: 5.0,
                flour: Flour.Wheat,
                dough: Dough.Shortbread,
                form: TypeOfForm.Rectangle,
                filling: Filling.CondensedMilk,
                spice: Spice.Cardamom);

            Console.WriteLine(carvedGingerbread.GetCaloricValue());
        }
    }
}
