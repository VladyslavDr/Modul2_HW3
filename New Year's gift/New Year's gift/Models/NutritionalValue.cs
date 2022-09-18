namespace New_Year_s_gift
{
    public class NutritionalValue
    {
        public NutritionalValue(double proteins, double fats, double carbs)
        {
            Proteins = proteins;
            Fats = fats;
            Carbs = carbs;
        }

        public double Proteins { get; init; }
        public double Fats { get; init; }
        public double Carbs { get; init; }
    }
}
