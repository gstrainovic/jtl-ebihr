using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayShippingprofile
{
    public int KEbayBenutzer { get; set; }

    public string? CProfilType { get; set; }

    public string? DiscountProfileId { get; set; }

    public string? DiscountProfileName { get; set; }

    public int SiteId { get; set; }
}
