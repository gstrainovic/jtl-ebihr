using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TOutboundItemRef
{
    public int KOutboundItemRef { get; set; }

    public int KAuftrag { get; set; }

    public int KAuftragPosition { get; set; }

    public string COutboundItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }

    public DateTimeOffset? DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public virtual TAuftragPosition KAuftragPositionNavigation { get; set; } = null!;
}
