using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAuftragsverwaltungCache
{
    public int KAuftrag { get; set; }

    public byte NAuftragStatus { get; set; }

    public int KBenutzer { get; set; }

    public int? KKunde { get; set; }

    public int? KVersandart { get; set; }

    public int? KInetBestellung { get; set; }

    public int KBestellhinweis { get; set; }

    public int KFirma { get; set; }

    public int KSprache { get; set; }

    public int? KShop { get; set; }

    public int? KZahlungsart { get; set; }

    public string CAuftragsnummer { get; set; } = null!;

    public int? KPlattform { get; set; }

    public string? CAnmerkung { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FWaehrungsfaktor { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public DateTime? DZahlungsmaildatum { get; set; }

    public byte NBeschreibung { get; set; }

    public int? NSteuereinstellung { get; set; }

    public string? CStatustext { get; set; }

    public DateTime? DBezahldatum { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public DateTime DErstellt { get; set; }

    public int? NZahlungszielTage { get; set; }

    public int NKomplettAusgeliefert { get; set; }

    public DateTime? DZahldatum { get; set; }

    public int? KRueckhaltegrund { get; set; }

    public string? CRueckhalteGrund { get; set; }

    public DateTime? DVersanddatum { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public int NLieferprioritaet { get; set; }

    public string? CVersandlandIso { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungFaktor { get; set; }

    public int NInet { get; set; }

    public byte NRechnungStatus { get; set; }

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

    public string? CBenutzername { get; set; }

    public string? CFirmenname { get; set; }

    public string? CShopname { get; set; }

    public string CKundengruppe { get; set; } = null!;

    public string? CZahlungsartname { get; set; }

    public string? CVersandartname { get; set; }

    public string? CKundeNr { get; set; }

    public int? NDebitorennr { get; set; }

    public decimal FAuftragswertBrutto { get; set; }

    public decimal? FAuftragswertVersandland { get; set; }

    public string? CSonstiges { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public int? NFarbcode { get; set; }

    public string? CFarbbedeutung { get; set; }

    public string? CeBayBenutzername { get; set; }

    public string? CeBayVerwendungszweck { get; set; }

    public byte? NStorniert { get; set; }

    public string? CZahlungsmodulId { get; set; }

    public decimal FGutgeschriebenerWert { get; set; }

    public decimal FBereitsgezahltWert { get; set; }

    public decimal FOffenerWert { get; set; }

    public decimal FAuftragswertNetto { get; set; }

    public byte? NWmsgesperrt { get; set; }

    public int? NWmsteillieferung { get; set; }

    public int? NWmsvorkommissionieren { get; set; }

    public byte NIstExterneRechnung { get; set; }

    public byte NIstReadOnly { get; set; }

    public byte NZahlungStatus { get; set; }

    public int NLieferstatus { get; set; }

    public int NPlattformTyp { get; set; }

    public int NInnergemeinschaftlicheLieferung { get; set; }

    public int NUmsatzsteuerfrei { get; set; }

    public string? CRechnungsnummern { get; set; }

    public bool NPending { get; set; }

    public DateTime? DStorniert { get; set; }

    public string? CStornoKommentar { get; set; }

    public string? CStornoBenutzername { get; set; }

    public string? CStornogrund { get; set; }
}
