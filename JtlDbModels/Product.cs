using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class Product
{
    public int ProductId { get; set; }

    public int VariationParentId { get; set; }

    public int GroupOfProductsId { get; set; }

    public int? ManufacturerId { get; set; }

    public int ProductStateId { get; set; }

    public int? ShippingClassId { get; set; }

    public int VatclassId { get; set; }

    public byte SpecialTypeId { get; set; }

    public string? ProductNumber { get; set; }

    public decimal NetSalesPrice { get; set; }

    public decimal Rrp { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public string? Ean { get; set; }

    public string? Upc { get; set; }

    public string? Isbn { get; set; }

    public byte IsParentItem { get; set; }

    public bool? IsPartsList { get; set; }

    public bool? IsBestSellingItem { get; set; }

    public byte HasBatch { get; set; }

    public byte HasSerialNo { get; set; }

    public byte HasBestBeforeDate { get; set; }

    public decimal ProductHeight { get; set; }

    public decimal ProductWidth { get; set; }

    public decimal ProductDepth { get; set; }

    public decimal ProductWeight { get; set; }

    public decimal ShippingWeight { get; set; }

    public decimal MinimumAmount { get; set; }

    public DateTime? CreationDate { get; set; }

    public byte[] LastChange { get; set; } = null!;

    public bool? IsStockActive { get; set; }
}
