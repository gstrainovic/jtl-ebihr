using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VOffenerPostenRechnungZahlung
{
    public int KZahlung { get; set; }

    public decimal FBetrag { get; set; }

    public DateTime? DDatum { get; set; }

    public string? CTransactionId { get; set; }

    public int KRechnung { get; set; }

    public string CRechnungsNr { get; set; } = null!;

    public string? CKundenNr { get; set; }

    public string? CGutschriftNr { get; set; }

    public decimal FBetragOffen { get; set; }

    public decimal? FBetragSkonto { get; set; }

    public byte NMatchingOptionen { get; set; }

    public decimal FMahngebuehr { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseName { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseName { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CEbayCheckoutVerwendungszweck { get; set; }

    public string CWaehrungIso { get; set; } = null!;

    public int? KAuftrag { get; set; }

    public string? CBestellNr { get; set; }

    public string? CExterneBestellNr { get; set; }

    public string? CEbayBuyerUserId { get; set; }

    public string? CEbayItemId { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? CTrackingId { get; set; }
}
