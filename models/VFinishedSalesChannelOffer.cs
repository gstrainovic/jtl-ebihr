using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VFinishedSalesChannelOffer
{
    public long KOffer { get; set; }

    public string? CChannelOfferId { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public byte NStatus { get; set; }

    public int KShop { get; set; }

    public int? KArtikel { get; set; }

    public bool NIsListed { get; set; }

    public byte NType { get; set; }
}
