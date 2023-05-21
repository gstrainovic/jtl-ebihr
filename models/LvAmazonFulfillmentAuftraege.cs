using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAmazonFulfillmentAuftraege
{
    public int KFulfillmentAuftrag { get; set; }

    public int? KLieferschein { get; set; }

    public int? KKunde { get; set; }

    public int? KLieferadresse { get; set; }

    public int? KWarenlager { get; set; }

    public int? KBenutzer { get; set; }

    public int? KSprache { get; set; }

    public DateTime? DErstelltAm { get; set; }

    public int? NFulfillmentDienstleister { get; set; }

    public int? NStatus { get; set; }

    public string? CLieferscheinnummer { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseKundennummer { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseName { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CFehlermeldung { get; set; }

    public DateTime? DInBearbeitung { get; set; }

    public string? CBestellnummer { get; set; }

    public string? CLieferadresseTel { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseEmail { get; set; }

    public int? KUser { get; set; }

    public string? CPfUsername { get; set; }

    public string? CKommentar { get; set; }

    public string? CLieferprioritaet { get; set; }

    public byte NWarenlagerFulfillment { get; set; }
}
