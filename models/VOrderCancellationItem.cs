using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderCancellationItem
{
    public int KOrder { get; set; }

    public string COrderItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }
}
