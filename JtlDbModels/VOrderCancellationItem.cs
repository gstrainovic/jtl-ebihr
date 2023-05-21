using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderCancellationItem
{
    public int KOrder { get; set; }

    public string COrderItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }
}
