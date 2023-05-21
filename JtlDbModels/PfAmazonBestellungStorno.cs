using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonBestellungStorno
{
    public int KAmazonBestellungStorno { get; set; }

    public string COrderId { get; set; } = null!;

    public byte NCancelReason { get; set; }

    public DateTime DErstellt { get; set; }

    public DateTime? DBearbeitet { get; set; }

    public int KBenutzer { get; set; }
}
