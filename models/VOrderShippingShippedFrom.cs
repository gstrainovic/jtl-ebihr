using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOrderShippingShippedFrom
{
    public int KAuftrag { get; set; }

    public string? CCity { get; set; }

    public string CCountryIso { get; set; } = null!;

    public string? CPostcode { get; set; }
}
