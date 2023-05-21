using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Product1
{
    public int InternalId { get; set; }

    public string Sku { get; set; } = null!;

    public decimal NetSalesPrice { get; set; }

    public decimal Rrp { get; set; }

    public string? Comment { get; set; }

    public bool? IsOnPriceList { get; set; }

    public bool? IsActive { get; set; }

    public decimal MinimumOrderQuantity { get; set; }

    public string? Ean { get; set; }

    public bool? IsBestSellingItem { get; set; }

    public decimal ShippingWeight { get; set; }

    public bool? IsNew { get; set; }

    public bool? IsSerialNumberItem { get; set; }

    public bool? IsSplitItem { get; set; }

    public bool? IsInventoryItem { get; set; }

    public bool? IsNegativeStockAllowed { get; set; }

    public decimal MinimumStockLevel { get; set; }

    public decimal PurchasePrice { get; set; }

    public decimal EBaySalesPrice { get; set; }

    public bool? IsVariationItem { get; set; }

    public decimal PackagingUnit { get; set; }

    public byte? BasePriceActive { get; set; }

    public decimal BasePriceValue { get; set; }

    public string? SearchTerms { get; set; }

    public string? Taric { get; set; }

    public string? CountryOfOrigin { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? PublicationDate { get; set; }

    public int? Sorting { get; set; }

    public decimal Weight { get; set; }

    public string? Mpn { get; set; }

    public string? Series { get; set; }

    public string? Isbn { get; set; }

    public string? Unnumber { get; set; }

    public string? HazardIdnumber { get; set; }

    public string? Asin { get; set; }

    public bool? IsParentItem { get; set; }

    public bool? HasMinimumStockLevel { get; set; }

    public decimal PackagingQuantity { get; set; }

    public int BillOfMaterialsInternalId { get; set; }

    public string? Upc { get; set; }

    public bool? IsSleditem { get; set; }

    public bool? IsBatchItem { get; set; }

    public bool? ConsideredInProposal { get; set; }

    public decimal AmazonSalesPrice { get; set; }

    public decimal UoMquantity { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Length { get; set; }

    public int? DeliveryTimeIfSoldOut { get; set; }

    public int? ProcessingTime { get; set; }

    public string? AmazonFnsku { get; set; }

    public string? Jtlfpid { get; set; }

    public int GroupOfProductsInternalId { get; set; }

    public string? ShippingClassName { get; set; }

    public int SupplierQuantity { get; set; }

    public bool? IsVariationCombination { get; set; }

    public decimal? TotalStock { get; set; }

    public decimal? ReservedStock { get; set; }

    public decimal? OrderedStock { get; set; }

    public decimal? AvailableStock { get; set; }
}
