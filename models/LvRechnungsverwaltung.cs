using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvRechnungsverwaltung
{
    public int KRechnung { get; set; }

    public int? KBenutzer { get; set; }

    public int? KKunde { get; set; }

    public string CWaehrung { get; set; } = null!;

    public int? KFirma { get; set; }

    public string? CFirmenname { get; set; }

    public string? CUmsatzsteuerId { get; set; }

    public int? KZahlungsart { get; set; }

    public string? CZahlungsartname { get; set; }

    public bool NMahnstopp { get; set; }

    public DateTime DErstellt { get; set; }

    public DateTime DValutadatum { get; set; }

    public string CRechnungsnummer { get; set; } = null!;

    public decimal FWaehrungsfaktor { get; set; }

    public int? KVersandart { get; set; }

    public string? CVersandart { get; set; }

    public bool NIstEntwurf { get; set; }

    public int? KShop { get; set; }

    public int? KPlattform { get; set; }

    public int? KSprache { get; set; }

    public int NSteuereinstellung { get; set; }

    public int NInnergemeinschaftlicheLieferung { get; set; }

    public int NUmsatzsteuerfrei { get; set; }

    public string? CeBayBenutzername { get; set; }

    public string CShopname { get; set; } = null!;

    public bool? NIstExterneRechnung { get; set; }

    public bool NExistierendeRechnungDrucken { get; set; }

    public DateTime? DBezahldatum { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public bool? NIstAngemahnt { get; set; }

    public decimal? FOffenerWert { get; set; }

    public decimal? FBereitsgezahltWert { get; set; }

    public bool? NIstKomplettBezahlt { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CSonstiges { get; set; }

    public decimal? FGutgeschriebenerWert { get; set; }

    public bool? NRechnungskorrekturErstellt { get; set; }

    public byte? NZahlungStatus { get; set; }

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

    public decimal? FGesamtBruttopreis { get; set; }

    public decimal? FRechnungswertVersandland { get; set; }

    public string? CBenutzername { get; set; }

    public string? CZahlungsart { get; set; }

    public string? CKundeNr { get; set; }

    public int? NDebitorennr { get; set; }

    public string? CKundengruppe { get; set; }

    public int? NZahlungszielInTagen { get; set; }

    public DateTime? DZahlungsziel { get; set; }

    public byte? NMahnstufe { get; set; }

    public DateTime? DMahndatum { get; set; }

    public bool NArchiv { get; set; }

    public int? NFarbcode { get; set; }

    public string? CFarbbedeutung { get; set; }

    public int? NPlattformTyp { get; set; }

    public string? CAuftragsNr { get; set; }

    public bool? NKorrigiert { get; set; }

    public bool NStorno { get; set; }

    public DateTime? DStorniert { get; set; }

    public string? CStornoKommentar { get; set; }

    public string? CStornoBenutzername { get; set; }

    public string? CStornogrund { get; set; }

    public int? KAuftrag { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public DateTime? DLetzterVersand { get; set; }
}
