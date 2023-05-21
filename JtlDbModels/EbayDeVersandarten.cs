using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayDeVersandarten
{
    public int KEbayDeVersandarten { get; set; }

    public string? Description { get; set; }

    public byte? ExpeditedService { get; set; }

    public byte? InternationalService { get; set; }

    public string? ShippingService { get; set; }

    public int? ShippingServiceId { get; set; }

    public byte? ShippingTimeMin { get; set; }

    public byte? ShippingTimeMax { get; set; }
}
