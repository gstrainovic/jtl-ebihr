using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayXxVersandlaender
{
    public int SiteId { get; set; }

    public string ShippingLocation { get; set; } = null!;

    public string CDescription { get; set; } = null!;
}
