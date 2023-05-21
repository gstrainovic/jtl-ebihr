using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFbabestand
{
    public int KUser { get; set; }

    public int KArtikel { get; set; }

    public int? NBestand { get; set; }

    public decimal? NBestandReserviert { get; set; }

    public string? CMarketplaceId { get; set; }

    public string? CRegion { get; set; }
}
