namespace New_Year_s_gift
{
    public class Manufacturer
    {
        public Manufacturer(string companyName, string importer, Country country)
        {
            CompanyName = companyName;
            Importer = importer;
            Country = country;
        }

        public string CompanyName { get; init; }
        public string Importer { get; init; }
        public Country Country { get; init; }
    }
}
