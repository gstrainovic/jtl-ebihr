using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvStornobelegverwaltung
{
    public int KStornobeleg { get; set; }

    public int? KRechnung { get; set; }

    public string? CStornobelegnummer { get; set; }

    public string? CKurztext { get; set; }

    public string? CText { get; set; }

    public decimal FPreis { get; set; }

    public decimal FMwst { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CErloeskonto { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FFaktor { get; set; }

    public int? KFirma { get; set; }

    public int? KSprache { get; set; }

    public int? KBenutzer { get; set; }

    public string? CStatustext { get; set; }

    public int? KRechnungsadresse { get; set; }

    public int? KPlattform { get; set; }

    public string CRechnungsnummer { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public string? CSonstiges { get; set; }

    public int? KShop { get; set; }

    public string? CShopname { get; set; }

    public int? KKunde { get; set; }

    public string? CRechnungsadresseFirma { get; set; }

    public string? CRechnungsadresseAnrede { get; set; }

    public string? CRechnungsadresseTitel { get; set; }

    public string? CRechnungsadresseVorname { get; set; }

    public string? CRechnungsadresseNachname { get; set; }

    public string? CRechnungsadresseStrasse { get; set; }

    public string? CRechnungsadresseAdresszusatz { get; set; }

    public string? CRechnungsadressePlz { get; set; }

    public string? CRechnungsadresseOrt { get; set; }

    public string? CRechnungsadresseLand { get; set; }

    public string? CRechnungsadresseTelefon { get; set; }

    public string? CRechnungsadresseMobilTelefon { get; set; }

    public string? CRechnungsadresseFax { get; set; }

    public string? CRechnungsadresseMail { get; set; }

    public string? CRechnungsadresseZusatz { get; set; }

    public string? CRechnungsadressePostId { get; set; }

    public string? CRechnungsadresseBundesland { get; set; }

    public string? CRechnungsadresseLandIso { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public string? CLieferadresseTitel { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadresseAdresszusatz { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseMobilTelefon { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadressePostId { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseLandIso { get; set; }

    public string? CKundeNr { get; set; }

    public string? CKundengruppe { get; set; }

    public string? CBenutzername { get; set; }

    public string? CFirmenname { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public string? CeBayBenutzername { get; set; }

    public bool NStorno { get; set; }

    public byte NStornoTyp { get; set; }
}
