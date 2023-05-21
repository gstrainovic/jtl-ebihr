using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvLogbuch
{
    public int KFulfillmentLog { get; set; }

    public int KBenutzer { get; set; }

    public DateTime DTimestamp { get; set; }

    public string? CSessionId { get; set; }

    public byte NLogLevel { get; set; }

    public byte NMessageSource { get; set; }

    public int? KLieferant { get; set; }

    public int? KLieferschein { get; set; }

    public int? KArtikelHistory { get; set; }

    public int? KWarenlager { get; set; }

    public int? KBestellung { get; set; }

    public int? KLieferantenBestellung { get; set; }

    public int? KFulfillmentAuftrag { get; set; }

    public int? KArtikel { get; set; }

    public int? KKunde { get; set; }

    public int? KRmRetoure { get; set; }

    public int? KLieferavis { get; set; }

    public string? CMessage { get; set; }

    public string? CMessageDetails { get; set; }

    public string? CRequestId { get; set; }

    public string? Artikelnummer { get; set; }

    public string? Artikelname { get; set; }

    public decimal? AnzahlGebucht { get; set; }

    public string? CLieferscheinNr { get; set; }

    public string? FulfillmentLieferant { get; set; }

    public string? FulfillmentLager { get; set; }

    public string? Bestellnummer { get; set; }

    public string? FulfillmentAuftrag { get; set; }

    public string? LieferantenBestellung { get; set; }

    public string? Bezugsnummer { get; set; }

    public string? Kundennummer { get; set; }

    public string? Retourennummer { get; set; }

    public string? Lieferavisnummer { get; set; }
}
