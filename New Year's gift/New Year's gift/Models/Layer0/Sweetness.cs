namespace New_Year_s_gift
{
    public abstract class Sweetness : ICaloricValue
    {
        public string Name { get; set; }
        public Weight Weight { get; set; }
        public Price Price { get; set; }
        public NutritionalValue NutritionalValue { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public double GetCaloricValue() => (9 * NutritionalValue.Fats) + (4 * NutritionalValue.Carbs) + (4 * NutritionalValue.Proteins);
    }
}
