using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOfferStockUpdate
{
    public int KChannel { get; set; }

    public string CChannel { get; set; } = null!;

    public string CSellerId { get; set; } = null!;

    public long KOffer { get; set; }

    public decimal? FQuantity { get; set; }

    public decimal? FLastUpdatedQuantity { get; set; }

    public DateTime DQuantityUpdatedAt { get; set; }

    public int? KProduct { get; set; }

    public int KShop { get; set; }

    public decimal NMindestbestand { get; set; }

    public decimal NMaximalerBestand { get; set; }

    public decimal? FChannelQuantity { get; set; }

    public DateTime? DChannelQuantityUpdatedAt { get; set; }

    public string? CChannelOfferId { get; set; }

    public byte NType { get; set; }
}
