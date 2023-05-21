using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonBestellungstatus
{
    public long KMessageId { get; set; }

    public int KUser { get; set; }

    public string? COrderId { get; set; }

    public string? COrderStatus { get; set; }

    public DateTime? DErstellt { get; set; }
}
