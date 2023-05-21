using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderShippingItem
{
    public int KAuftrag { get; set; }

    public string? CTrackingNumber { get; set; }

    public string? CCarrier { get; set; }

    public int KDeliveryNote { get; set; }

    public DateTime? DShippedAt { get; set; }

    public string? CReturnTrackingNumber { get; set; }

    public string? CReturnCarrier { get; set; }
}
