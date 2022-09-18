namespace New_Year_s_gift
{
    public class Price
    {
        public Price(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }

        public decimal Value { get; init; }
        public Currency Currency { get; init; }
    }
}
