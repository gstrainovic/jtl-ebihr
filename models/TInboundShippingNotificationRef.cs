using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TInboundShippingNotificationRef
{
    public int KLieferavis { get; set; }

    public string CInboundShippingNotificationId { get; set; } = null!;

    public string COwnerId { get; set; } = null!;

    public DateTimeOffset DCreatedAt { get; set; }

    public DateTimeOffset? DUpdatedAt { get; set; }

    public virtual TLieferavi KLieferavisNavigation { get; set; } = null!;
}
