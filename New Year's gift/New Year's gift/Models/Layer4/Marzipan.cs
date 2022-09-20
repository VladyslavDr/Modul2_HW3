namespace New_Year_s_gift
{
    public class Marzipan : Candy
    {
        public Marzipan(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, TypeOfForm form, CandyWrapper candyWrapper, Glaze glaze, Filling filling)
           : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, form, candyWrapper)
        {
            Glaze = glaze;
            Filling = filling;
        }

        public Glaze Glaze { get; init; }
        public Filling Filling { get; init; }
    }
}
