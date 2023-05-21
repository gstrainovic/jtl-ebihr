using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayShippingServiceOption
{
    public int KShippingServiceOptions { get; set; }

    public int KItem { get; set; }

    public int ShippingServiceId { get; set; }

    public decimal ShippingServiceAdditionalCost { get; set; }

    public decimal ShippingServiceCost { get; set; }

    public byte? ShippingServicePriority { get; set; }

    public string? ShippingService { get; set; }
}
