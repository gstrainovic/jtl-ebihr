using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VSalesChannelOffer
{
    public long KOffer { get; set; }

    public int KCategory { get; set; }

    public decimal? FQuantity { get; set; }

    public decimal? FLastUpdatedQuantity { get; set; }

    public DateTime DQuantityUpdatedAt { get; set; }

    public byte NStatus { get; set; }

    public int? KProduct { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public int KShop { get; set; }

    public int KChannel { get; set; }

    public string? CCategory { get; set; }

    public decimal NMindestbestand { get; set; }

    public decimal NMaximalerBestand { get; set; }

    public decimal? FChannelQuantity { get; set; }

    public DateTime? DChannelQuantityUpdatedAt { get; set; }

    public string? CChannelOfferId { get; set; }

    public long KParentOffer { get; set; }

    public bool? NIsListed { get; set; }

    public string? CGtin { get; set; }

    public string? CHash { get; set; }
}
