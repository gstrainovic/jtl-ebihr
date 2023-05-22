using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

class Csv
{
    public static void GenerateBrands()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ",",
            MissingFieldFound = null,
            BadDataFound = null,
            IgnoreBlankLines = true,
            TrimOptions = TrimOptions.Trim,
            Encoding = Encoding.UTF8
        };

        //  make a list of brands, without duplicates from the csv files in env.tempPath

        var brands = new List<Brand>();

        foreach (var file in Directory.GetFiles(env.tempPath, "*.csv"))
        {
            Logger.Info($"Processing {file}");
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<Catalog>();

                foreach (var record in records)
                {
                    if (!brands.Any(x => x.Name == record.Brand))
                    {
                        brands.Add(new Brand { Name = record.Brand });
                    }
                }
            }
        }

        // save the list of brands to a csv file
        using (var writer = new StreamWriter(Path.Combine(env.tempPath, "brands.csv")))
        using (var csv = new CsvWriter(writer, config))
        {
            csv.WriteRecords(brands);
        }

    }

    public class Brand
    {
        public string Name
        {
            get; set;
        }
    }

    public class Catalog
    {
        public string CategoryPath { get; set; }
        public string ProductId { get; set; }
        public string BarCode { get; set; }
        public string DiscountClass { get; set; }
        public string FurtherDescription { get; set; }
        public int Height { get; set; }
        public decimal PublicPriceHT { get; set; }
        public decimal PublicPriceTTC { get; set; }
        public bool EndOfLifeProduct { get; set; }
        public bool IsPartialShippingAllowed { get; set; }
        public bool IsRemainingOnBackOrderAllowed { get; set; }
        public int Length { get; set; }
        public string LongDescription1 { get; set; }
        public string LongDescription2 { get; set; }
        public string LongDescription3 { get; set; }
        public int SalesMultiple { get; set; }
        public string ShortDescription1 { get; set; }
        public string ShortDescription2 { get; set; }
        public string ShortDescription3 { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public string Brand { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string NewPartNumber { get; set; }
        public string CommodityCode { get; set; }
    }
}
