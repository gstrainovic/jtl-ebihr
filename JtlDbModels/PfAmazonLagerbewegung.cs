using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class PfAmazonLagerbewegung
{
    public int KAmazonLagerbewegung { get; set; }

    public int KUser { get; set; }

    public int KArtikel { get; set; }

    public int NMenge { get; set; }

    public string? CFulfillmentCenter { get; set; }

    public DateTime? DSnapshot { get; set; }

    public byte? NStatus { get; set; }

    public string? CTransactionType { get; set; }

    public long? KMessageId { get; set; }
}
