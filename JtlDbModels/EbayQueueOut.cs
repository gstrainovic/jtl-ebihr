using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayQueueOut
{
    public string? ItemId { get; set; }

    public string? TransactionId { get; set; }

    public int? KEbayUser { get; set; }

    public short? NType { get; set; }

    public string? CIdentcode { get; set; }

    public string? CCarrierCode { get; set; }
}
