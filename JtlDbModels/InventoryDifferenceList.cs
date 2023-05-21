using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class InventoryDifferenceList
{
    public decimal? TotalPurchasePriceNet { get; set; }

    public decimal? QuantityDifference { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }
}
