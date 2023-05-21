using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TOffer
{
    public long KOffer { get; set; }

    public int KCategory { get; set; }

    public decimal? FQuantity { get; set; }

    public byte NStatus { get; set; }

    public string? CErrorMessage { get; set; }

    public DateTime? DExpirationDate { get; set; }

    public DateTime? DActiveSince { get; set; }

    public int? KArtikel { get; set; }

    public DateTime? DFailedAt { get; set; }

    public int KShop { get; set; }

    public byte NType { get; set; }

    public bool NIsListed { get; set; }

    public string? CChannelOfferId { get; set; }

    public string? CListingUrl { get; set; }

    public DateTime DQuantityUpdatedAt { get; set; }

    public long KParentOffer { get; set; }

    public DateTime? DBeendet { get; set; }

    public DateTime? DLetzterUpload { get; set; }

    public DateTime? DPriceUpdatedUtc { get; set; }

    public DateTime? DStatusReceivedUtc { get; set; }

    public decimal FZuletztHochgeladenerPreis { get; set; }

    public string? CHash { get; set; }

    public virtual ICollection<TExternOffer> TExternOffers { get; set; } = new List<TExternOffer>();

    public virtual ICollection<TOfferFailure> TOfferFailures { get; set; } = new List<TOfferFailure>();
}
