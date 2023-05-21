using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class CustomerGroup1
{
    public int InternalId { get; set; }

    public string? Name { get; set; }

    public decimal DiscountInPercent { get; set; }
}
