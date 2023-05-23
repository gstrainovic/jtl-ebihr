using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using JtlDbModels;

class Csv
{
    CsvConfiguration? config;

    public Csv() {


        config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
            Delimiter = ",",
            MissingFieldFound = null,
            BadDataFound = null,
            IgnoreBlankLines = true,
            TrimOptions = TrimOptions.Trim,
            Encoding = Encoding.UTF8
        };
        if (config == null)
        {
            Logger.Error("config is null");
            return;
        }
    }

    public void GenerateBrands(string catalogTempDir)
    {

        string importBrandsFilePath = Path.Combine(Config.tempPath, "importBrands.csv");
        if (importBrandsFilePath == null)
        {
            Logger.Error("importBrandsFilePath is null");
            return;
        }

        var bihrBrands = new List<Brand>();
        foreach (var file in Directory.GetFiles(catalogTempDir, "*.csv"))
        {
            Logger.Info($"Processing {file}");
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<CatalogHardParts>();

                foreach (var record in records)
                {
                    if (!bihrBrands.Any(x => x.Name == record.Brand))
                    {
                        bihrBrands.Add(new Brand { Name = record.Brand });
                    }
                }
            }
        }

        // read the brands from JTL
        using var db = new EazyBusinessContext();
        var jtlBrands = db.THerstellers.ToList();

        // compare the brands from JTL with the brands from Bihr
        // if the brand from Bihr is not in JTL, make a new import csv file
        var importBrands = new List<Brand>();
        foreach (var bihrBrand in bihrBrands)
        {
            if (!jtlBrands.Any(x => x.CName == bihrBrand.Name))
            {
                importBrands.Add(new Brand { Name = bihrBrand.Name });
                Logger.Info($"Brand {bihrBrand.Name} not found in JTL, added to {importBrandsFilePath}");
            }
        }



        // save the import csv file if importBrands is not empty
        if (importBrands.Count == 0)
        {
            Logger.Info($"No brands to import");
        }
        else
        {
            // delete the import csv file if it exists
            if (File.Exists(Path.Combine(Config.tempPath, importBrandsFilePath)))
            {
                File.Delete(Path.Combine(Config.tempPath, importBrandsFilePath));
            }
            using (var writer = new StreamWriter(Path.Combine(Config.tempPath, importBrandsFilePath)))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(importBrands);
                Logger.Info($"Saved {importBrandsFilePath}");
            }
        }

        bool importBrandsFileExists = File.Exists(Path.Combine(Config.tempPath, importBrandsFilePath));

        if (importBrandsFileExists && importBrandsFilePath != null)
        {
            Ameise ameise = new Ameise();
            ameise.importBrands(importBrandsFilePath);
        }


    }

    public class Brand
    {
        public string? Name
        {
            get; set;
        }
    }

    public class CatalogExtendedReferences
    {
        public string? CategoryPath { get; set; }
        public string? ProductId { get; set; }
        public string? BarCode { get; set; }
        public string? DiscountClass { get; set; }
        public string? FurtherDescription { get; set; }
        public int Height { get; set; }
        public decimal PublicPriceHT { get; set; }
        public decimal PublicPriceTTC { get; set; }
        public bool EndOfLifeProduct { get; set; }
        public bool IsPartialShippingAllowed { get; set; }
        public bool IsRemainingOnBackOrderAllowed { get; set; }
        public int Length { get; set; }
        public string? LongDescription1 { get; set; }
        public string? LongDescription2 { get; set; }
        public string? LongDescription3 { get; set; }
        public int SalesMultiple { get; set; }
        public string? ShortDescription1 { get; set; }
        public string? ShortDescription2 { get; set; }
        public string? ShortDescription3 { get; set; }
        public int Volume { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public string? Brand { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? NewPartNumber { get; set; }
        public string? CommodityCode { get; set; }
    }

    // ProductCode,SupplierProductCode,Brand,MainCategory,ProductName,Designation,Weight,
    // RetailPriceIncludingTax,RetailPriceExcludingTax,BaseDealerPriceExcludingTax,BarCode,SalesMultiple,
    // StockLevel,DefaultPicture,NewPartNumber,StockValue,CommodityCode																
    public class CatalogHardParts
    {
        public string? ProductCode { get; set; }
        public string? SupplierProductCode { get; set; }
        public string? Brand { get; set; }
        public string? MainCategory { get; set; }
        public string? ProductName { get; set; }
        public string? Designation { get; set; }
        public int Weight { get; set; }
        public decimal RetailPriceIncludingTax { get; set; }
        public decimal RetailPriceExcludingTax { get; set; }
        public decimal BaseDealerPriceExcludingTax { get; set; }
        public string? BarCode { get; set; }
        public int SalesMultiple { get; set; }
        public string? StockLevel { get; set; }
        public string? DefaultPicture { get; set; }
        public string? NewPartNumber { get; set; }
        public int StockValue { get; set; }
        public string? CommodityCode { get; set; }
    }
}
