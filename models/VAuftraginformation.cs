using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VAuftraginformation
{
    public int KAuftrag { get; set; }

    public int? KShopauftrag { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public int NKomplettAusgeliefert { get; set; }

    public string? CPlz { get; set; }

    public int? KShop { get; set; }

    public DateTime? DVersandt { get; set; }

    public string? CIdentCode { get; set; }

    public string? CVersandInfo { get; set; }

    public string? CLogistik { get; set; }

    public string? CTrackingUrlTemplate { get; set; }

    public string CBezahlt { get; set; } = null!;

    public DateTime? DBezahltAm { get; set; }

    public string? CZahlungsartName { get; set; }
}
