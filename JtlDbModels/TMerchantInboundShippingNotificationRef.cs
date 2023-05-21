using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TMerchantInboundShippingNotificationRef
{
    public int KMerchantInboundShippingNotificationRef { get; set; }

    public int KLieferschein { get; set; }

    public DateTimeOffset DCreatedAt { get; set; }

    public string? CInboundShippingNotificationId { get; set; }

    public virtual TLieferschein KLieferscheinNavigation { get; set; } = null!;
}
