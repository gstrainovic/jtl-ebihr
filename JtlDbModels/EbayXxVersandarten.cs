using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxVersandarten
{
    public int SiteId { get; set; }

    public string CDescription { get; set; } = null!;

    public byte? ExpeditedService { get; set; }

    public byte? InternationalService { get; set; }

    public string ShippingService { get; set; } = null!;

    public int ShippingServiceId { get; set; }

    public byte ShippingTimeMin { get; set; }

    public byte ShippingTimeMax { get; set; }

    public int MappedToShippingServiceId { get; set; }
}
