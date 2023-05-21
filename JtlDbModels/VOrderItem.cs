using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderItem
{
    public int KOrder { get; set; }

    public int KOrderPos { get; set; }

    public int? KProduct { get; set; }

    public decimal FPriceNet { get; set; }

    public decimal FVat { get; set; }

    public decimal NQuantity { get; set; }

    public string? CName { get; set; }

    public string? CSku { get; set; }

    public string? CUnit { get; set; }

    public byte NType { get; set; }

    public decimal FDiscount { get; set; }

    public string? CNote { get; set; }

    public decimal FPurchasePriceNet { get; set; }

    public int? KConfigurationParent { get; set; }

    public int? KConfigurationitem { get; set; }

    public string? CVoucherId { get; set; }

    public string? CUsageId { get; set; }
}
