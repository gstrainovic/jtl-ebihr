using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class InventoryDifferenceListPosition
{
    public string Sku { get; set; } = null!;

    public int ItemInternalId { get; set; }

    public string ItemDescription { get; set; } = null!;

    public string ItemBarCode { get; set; } = null!;

    public string Asin { get; set; } = null!;

    public byte IsBatchItem { get; set; }

    public byte IsSleditem { get; set; }

    public int IsSerialNumberItem { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? UserName { get; set; }

    public int? UserInternalId { get; set; }

    public decimal? PurchasePriceNetPerSalesUnit { get; set; }

    public decimal? TotalPurchasePriceNet { get; set; }
}
