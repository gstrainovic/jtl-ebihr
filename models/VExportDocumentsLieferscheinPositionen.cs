using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VExportDocumentsLieferscheinPositionen
{
    public string? Beschreibung { get; set; }

    public string? StandardBeschreibung { get; set; }

    public string? Herkunftsland { get; set; }

    public decimal? Anzahl { get; set; }

    public decimal? Nettogewicht { get; set; }

    public decimal? Bruttogewicht { get; set; }

    public decimal? Wert { get; set; }

    public string? Artikelnummer { get; set; }

    public string? TaricNummer { get; set; }

    public string? Waehrung { get; set; }

    public string? HerkunftlandIso { get; set; }

    public string? HerkunftlandIso3 { get; set; }

    public int KLieferschein { get; set; }

    public int KAuftrag { get; set; }

    public int HerkunftslandIstIso { get; set; }

    public byte? Typ { get; set; }
}
