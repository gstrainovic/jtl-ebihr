using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvFulfillmentauftrag
{
    public int Id { get; set; }

    public DateTime? DErstelltAm { get; set; }

    public int? NStatus { get; set; }

    public DateTime? DInBearbeitungSeit { get; set; }

    public string? CKommentar { get; set; }

    public string? CLieferprioritaet { get; set; }

    public string? CBezugsauftragsnummer { get; set; }

    public string? CBezugslieferscheinnummer { get; set; }

    public string CDienstleister { get; set; } = null!;

    public int? NAmazonUser { get; set; }

    public string? CFehlermeldung { get; set; }

    public string? CKundenNummer { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseAdressZusatz { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public int? NFulfillmentDienstleister { get; set; }

    public string? CStornoCode { get; set; }

    public string? CStornoGrund { get; set; }

    public int? KKunde { get; set; }

    public int KFirma { get; set; }

    public string? CKundeNr { get; set; }

    public string? CRechnungsadresseTitel { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CRechnungsadresseNachname { get; set; }

    public string? CRechnungsadresseZusatz { get; set; }

    public string? CRechnungsadresseAdressZusatz { get; set; }

    public string? CRechnungsadresseStrasse { get; set; }

    public string? CRechnungsadressePlz { get; set; }

    public string? CRechnungsadresseOrt { get; set; }

    public string? CRechnungsadresseLand { get; set; }

    public string? CRechnungsadresseMail { get; set; }

    public string? CRechnungsadresseTelefon { get; set; }

    public string? CRechnungsadresseFax { get; set; }

    public string? CTransaktionsnummer { get; set; }
}
