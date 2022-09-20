namespace New_Year_s_gift
{
    public class Candy : SugarProduct
    {
        public Candy(string name, Weight weight, Price price, NutritionalValue nutritionalvalue, Manufacturer manufacturer, double sugarAmount, TypeOfForm form, CandyWrapper candyWrapper)
        {
            Name = name;
            Weight = new Weight(weight.Value, weight.Measure);
            Price = new Price(price.Value, price.Currency);
            NutritionalValue = new NutritionalValue(
                proteins: nutritionalvalue.Proteins,
                fats: nutritionalvalue.Fats,
                carbs: nutritionalvalue.Carbs);
            Manufacturer = new Manufacturer(
                companyName: manufacturer.CompanyName,
                importer: manufacturer.Importer,
                country: manufacturer.Country);
            SugarAmount = sugarAmount;
            Form = form;
            CandyWrapper = new CandyWrapper(candyWrapper.Material, candyWrapper.Color);
        }

        public CandyWrapper CandyWrapper { get; set; }
    }
}
