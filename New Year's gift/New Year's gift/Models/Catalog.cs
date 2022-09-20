using System;

namespace New_Year_s_gift
{
    public class Catalog
    {
        private static Catalog _instance;

        private Catalog()
        {
            Sweetness = new Sweetness[]
            {
                new Cracker(
                name: "TuC",
                weight: new Weight(value: 21, measure: Measure.Gr),
                price: new Price(value: 23.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 4.935, proteins: 1.575, carbs: 13.335),
                manufacturer: new Manufacturer(companyName: "Джури Кекс КФТ", importer: "ЗАО «Крафт Фудз Украина»", country: Country.Ukraine),
                sugarAmount: 5.0,
                flour: Flour.Wheat,
                dough: Dough.Puff,
                flavorAdditive: FlavorAdditive.Bacon),

                new JellyMarmalade(
                name: "Jelly Bears",
                weight: new Weight(value: 210, measure: Measure.Gr),
                price: new Price(value: 48.5M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 1.001, proteins: 14.142, carbs: 154.095),
                manufacturer: new Manufacturer(companyName: "Haribo", importer: "ФИО «I dont know»", country: Country.Germany),
                sugarAmount: 154.0,
                thickener: Thickener.Gelatin,
                form: TypeOfForm.Bear,
                color: ConsoleColor.Green,
                flavorAdditive: FlavorAdditive.Orange),

                new Fruity_BerryMarmalade(
                name: "Банановые Червячки",
                weight: new Weight(value: 200, measure: Measure.Gr),
                price: new Price(value: 65.99M, currency: Currency.UAH),
                nutritionalvalue: new NutritionalValue(fats: 0.095, proteins: 11.07, carbs: 135.066),
                manufacturer: new Manufacturer(companyName: "УВлада", importer: "Такси «Болт»", country: Country.Ukraine),
                sugarAmount: 154.0,
                thickener: Thickener.Agar_agar,
                form: TypeOfForm.Warm,
                color: ConsoleColor.Green,
                fruit: Fruit.Banana),

                new CarvedGingerbread(
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
                spice: Spice.Cardamom),

                new Lollipop(
                name: "Барбариска",
                weight: new Weight(value: 100, measure: Measure.Gr),
                price: new Price(value: 54.99M, Currency.UAH),
                nutritionalvalue: new NutritionalValue(proteins: 0.5, fats: 1.001, carbs: 96.005),
                manufacturer: new Manufacturer(companyName: "ROSHEN", importer: "ROSHEN", country: Country.Ukraine),
                sugarAmount: 7.2,
                form: TypeOfForm.Oval,
                flavorAdditive: FlavorAdditive.Barabaris,
                color: ConsoleColor.Red,
                candyWrapper: new CandyWrapper(material: Material.Plastic, color: ConsoleColor.White)),

                new GlazedCaramel(
                name: "Рачёк",
                weight: new Weight(value: 100, measure: Measure.Gr),
                price: new Price(value: 35.99M, Currency.UAH),
                nutritionalvalue: new NutritionalValue(proteins: 0.5, fats: 1.5, carbs: 105.805),
                manufacturer: new Manufacturer(companyName: "ROSHEN", importer: "ROSHEN", country: Country.Ukraine),
                sugarAmount: 10.5,
                form: TypeOfForm.Oval,
                flavorAdditive: FlavorAdditive.Milk,
                color: ConsoleColor.White,
                candyWrapper: new CandyWrapper(material: Material.Plastic, color: ConsoleColor.White),
                glaze: Glaze.Dairy),

                new Marzipan(
                name: "Marzipan",
                weight: new Weight(value: 100, measure: Measure.Gr),
                price: new Price(value: 35.99M, Currency.UAH),
                nutritionalvalue: new NutritionalValue(proteins: 9.2, fats: 35.8, carbs: 43.5),
                manufacturer: new Manufacturer(companyName: "Zentis", importer: "Товары с Европы", country: Country.Germany),
                sugarAmount: 40.8,
                form: TypeOfForm.Cylinder,
                candyWrapper: new CandyWrapper(material: Material.Foil, color: ConsoleColor.Yellow),
                glaze: Glaze.Chocolate,
                filling: Filling.Almond),

                new DriedFruit(
                name: "У Ашота на 1КМ",
                weight: new Weight(value: 100, measure: Measure.Gr),
                price: new Price(value: 130.99M, Currency.UAH),
                nutritionalValue: new NutritionalValue(proteins: 3.5, fats: 0.0, carbs: 79.0),
                manufacturer: new Manufacturer(companyName: "Zentis", importer: "Товары с Европы", country: Country.Germany),
                fruit: Fruit.Grapes),
            };
        }

        public Sweetness[] Sweetness { get; init; }

        public static Catalog GetInstance()
        {
            if (_instance is null)
            {
                _instance = new Catalog();
            }

            return _instance;
        }
    }
}
