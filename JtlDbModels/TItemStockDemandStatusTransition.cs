using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TItemStockDemandStatusTransition
{
    public int KItemStockDemandStatusTransition { get; set; }

    public int KItemStockDemand { get; set; }

    public int KBenutzer { get; set; }

    public string CComment { get; set; } = null!;

    public byte NPreviousStatus { get; set; }

    public byte NNextStatus { get; set; }

    public DateTimeOffset DCreationDate { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public virtual TItemStockDemand KItemStockDemandNavigation { get; set; } = null!;
}
