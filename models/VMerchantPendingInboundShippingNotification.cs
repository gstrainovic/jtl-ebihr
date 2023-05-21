using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VMerchantPendingInboundShippingNotification
{
    public int? KLieferschein { get; set; }

    public int KLieferantenBestellung { get; set; }

    public string? MerchantInboundNumber { get; set; }

    public string? InboundId { get; set; }

    public string? InboundShippingNotificationId { get; set; }

    public string? MerchantShippingNotificationNumber { get; set; }

    public string? Note { get; set; }
}
