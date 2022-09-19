namespace New_Year_s_gift
{
    public class DriedFruit : Sweetness
    {
        public DriedFruit(string name, Weight weight, Price price, NutritionalValue nutritionalValue, Manufacturer manufacturer)
        {
            Name = name;
            Weight = new Weight(weight.Value, weight.Measure);
            Price = new Price(price.Value, price.Currency);
            NutritionalValue = new NutritionalValue(nutritionalValue.Carbs, nutritionalValue.Fats, nutritionalValue.Proteins);
            Manufacturer = new Manufacturer(manufacturer.CompanyName, manufacturer.Importer, manufacturer.Country);
    }
        public Fruit Fruit { get; init; }
    }
}
