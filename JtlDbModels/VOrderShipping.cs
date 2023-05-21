using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOrderShipping
{
    public int KOrderShipping { get; set; }

    public int KOrder { get; set; }

    public int KAuftrag { get; set; }

    public string CSellerId { get; set; } = null!;

    public string? COrderIdExternal { get; set; }

    public bool? NShippingComplete { get; set; }

    public string CChannelId { get; set; } = null!;

    public int KDeliveryNote { get; set; }
}
