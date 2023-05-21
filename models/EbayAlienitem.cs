using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class EbayAlienitem
{
    public int KAlienItem { get; set; }

    public string? Title { get; set; }

    public string? ItemId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ListingType { get; set; }

    public int Quantity { get; set; }

    public int QuantityAvailable { get; set; }

    public int? SsBidderCount { get; set; }

    public int? SsBidCount { get; set; }

    public decimal SsCurrentPrice { get; set; }

    public string? SsHighBidderUserId { get; set; }

    public decimal StartPrice { get; set; }

    public decimal BuyItNowPrice { get; set; }

    public string? CurrencyId { get; set; }

    public string? UserId { get; set; }

    public byte? Status { get; set; }

    public int? KEbayuser { get; set; }

    public string? Sku { get; set; }

    public decimal Vatpercent { get; set; }

    public int? SiteId { get; set; }

    public virtual ICollection<TNegotiationAngebotStatus> TNegotiationAngebotStatuses { get; set; } = new List<TNegotiationAngebotStatus>();

    public virtual ICollection<TNegotiationAngebot> TNegotiationAngebots { get; set; } = new List<TNegotiationAngebot>();

    public virtual ICollection<TNegotiationAutomatisierung> TNegotiationAutomatisierungs { get; set; } = new List<TNegotiationAutomatisierung>();

    public virtual ICollection<TNegotiationItem> TNegotiationItems { get; set; } = new List<TNegotiationItem>();

    public virtual ICollection<TNegotiationVerlauf> TNegotiationVerlaufs { get; set; } = new List<TNegotiationVerlauf>();
}
