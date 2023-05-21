using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class EbayMapitem
{
    public int? KEbayuser { get; set; }

    public string? Title { get; set; }

    public string ItemId { get; set; } = null!;

    public string? Sku { get; set; }

    public int? Quantity { get; set; }

    public decimal CurrentPrice { get; set; }

    public string? Currency { get; set; }

    public DateTime? EndTime { get; set; }

    public string? ListingType { get; set; }

    public string? CJsondata { get; set; }

    public byte[]? BinJsondata { get; set; }

    public int? KEbayMapitemSuchString { get; set; }

    public int SiteId { get; set; }
}
