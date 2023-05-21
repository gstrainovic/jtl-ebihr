using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VOffenerPostenRechnung
{
    public int KRechnung { get; set; }

    public string CRechnungsnr { get; set; } = null!;

    public decimal FWert { get; set; }

    public decimal FZahlung { get; set; }

    public decimal FWertOffen { get; set; }

    public string? CKundenNr { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseName { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseName { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public decimal? FSkontoBetrag { get; set; }

    public decimal FMahngebuehr { get; set; }

    public string? CGutschriftNr { get; set; }

    public DateTime DErstellt { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public int NStorno { get; set; }

    public string? CEbayCheckoutVerwendungszweck { get; set; }

    public int? KAuftrag { get; set; }

    public string? CBestellNr { get; set; }

    public string? CExterneBestellNr { get; set; }

    public string? CEbayBuyerUserId { get; set; }

    public string? CEbayItemId { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? CTrackingId { get; set; }

    public string? CPaymentBestellNr { get; set; }
}
