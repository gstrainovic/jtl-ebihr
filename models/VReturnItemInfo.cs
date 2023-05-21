using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VReturnItemInfo
{
    public int KOutboundItemRef { get; set; }

    public string COutboundItemId { get; set; } = null!;

    public decimal FQuantity { get; set; }

    public int KAuftrag { get; set; }

    public int KAuftragPosition { get; set; }

    public int KLieferscheinPos { get; set; }

    public string? COutboundId { get; set; }

    public int? KArtikel { get; set; }

    public string? ArtikelNummer { get; set; }

    public string? Artikelname { get; set; }
}
