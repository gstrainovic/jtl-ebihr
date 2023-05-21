using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderReturnItem
{
    public int KAuftrag { get; set; }

    public string COrderItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }

    public string CReturnReason { get; set; } = null!;

    public string? CNote { get; set; }

    public string CCondition { get; set; } = null!;

    public bool? NAcceptReturn { get; set; }

    public bool? NRequireReturnShipping { get; set; }
}
