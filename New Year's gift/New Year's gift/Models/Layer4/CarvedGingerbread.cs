namespace New_Year_s_gift
{
    public class CarvedGingerbread : Gingerbread
    {
        public CarvedGingerbread(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, Flour flour, Dough dough, TypeOfForm form, Filling filling, Spice spice)
        : base(name, weight, price, nutritionalvalue, manufacturer, sugarAmount, flour, dough, spice)
        {
            Form = form;
            Filling = filling;
        }

        public TypeOfForm Form { get; init; }
        public Filling Filling { get; init; }
    }
}
