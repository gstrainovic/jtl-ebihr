using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonRetourmeldung
{
    public int KAmazonRetourMeldung { get; set; }

    public string? COrderId { get; set; }

    public string? COrderItemId { get; set; }

    public string? CCancelReason { get; set; }

    public string? CAdjustmentReason { get; set; }

    public DateTime? DErstellt { get; set; }

    public DateTime? DBearbeitet { get; set; }
}
