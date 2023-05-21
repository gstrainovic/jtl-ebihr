using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOfferPriceUpdate
{
    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public long KOffer { get; set; }

    public int? KProduct { get; set; }

    public int KShop { get; set; }

    public string? CChannelOfferId { get; set; }

    public byte NType { get; set; }
}
