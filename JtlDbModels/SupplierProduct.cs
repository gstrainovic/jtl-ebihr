using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class SupplierProduct
{
    public int SupplierProductId { get; set; }

    public int ProductId { get; set; }

    public int SupplierId { get; set; }

    public string? SupplierProductNumber { get; set; }

    public string? SupplierProductName { get; set; }

    public decimal NetPurchasePrice { get; set; }

    public decimal Vatpercent { get; set; }

    public string? PackingUnit { get; set; }

    public decimal? PackingAmount { get; set; }

    public int? MinimumOrderAmount { get; set; }

    public decimal OrderInterval { get; set; }

    public int? DeliveryDuration { get; set; }

    public byte IsDefault { get; set; }

    public byte[] LastChange { get; set; } = null!;
}
