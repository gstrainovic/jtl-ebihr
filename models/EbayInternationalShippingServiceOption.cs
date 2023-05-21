using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayInternationalShippingServiceOption
{
    public int KInternationalShippingServiceOption { get; set; }

    public int KItem { get; set; }

    public int ShippingServiceId { get; set; }

    public decimal ShippingServiceAdditionalCost { get; set; }

    public decimal ShippingServiceCost { get; set; }

    public byte? ShippingServicePriority { get; set; }

    public string? ShipToLocation { get; set; }

    public string? ShippingService { get; set; }
}
