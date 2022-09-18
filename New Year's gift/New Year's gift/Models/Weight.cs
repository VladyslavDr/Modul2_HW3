namespace New_Year_s_gift
{
    public class Weight
    {
        public Weight(double value, Measure measure)
        {
            Value = value;
            Measure = measure;
        }

        public double Value { get; init; }
        public Measure Measure { get; init; }
    }
}
