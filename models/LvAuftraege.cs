using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAuftraege
{
    public int KKunde { get; set; }

    public int KBestellung { get; set; }

    public int KRechnung { get; set; }

    public int KBenutzer { get; set; }

    public int KText { get; set; }

    public int? KBestellhinweis { get; set; }

    public int NPlattform { get; set; }

    public int? KColor { get; set; }

    public string CAuftragsnummer { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public string? CVersandinfo { get; set; }

    public DateTime? DVersanddatum { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public DateTime? DVersandmaildatum { get; set; }

    public DateTime? DZahlungsmaildatum { get; set; }

    public string? CBeschreibung { get; set; }

    public int KRueckhalteGrund { get; set; }

    public int? NAuftragsprioritaet { get; set; }

    public string? CBenutzername { get; set; }

    public string? CFirmenname { get; set; }

    public string? CShopname { get; set; }

    public string? CZahlungsartname { get; set; }

    public string? CVersandartname { get; set; }

    public string? CShopbestellnummer { get; set; }

    public int NInnergemeinschaftlicheLieferung { get; set; }

    public int NUmsatzsteuerfrei { get; set; }

    public string? CStatustext { get; set; }

    public string? CeBayBenutzername { get; set; }

    public string CeBayVerwendungszweck { get; set; } = null!;

    public byte? NStorniert { get; set; }

    public DateTime? DBezahldatum { get; set; }

    public string? CZahlungsmodulId { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public DateTime? DErstellt { get; set; }

    public string? CRueckhalteGrund { get; set; }

    public string? CRechnungsnummer { get; set; }

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

    public string? CRechnungsadresseMobiltelefonnummer { get; set; }

    public string? CRechnungsadresseFax { get; set; }

    public string? CRechnungsadresseMail { get; set; }

    public string? CRechnungsadresseZusatz { get; set; }

    public string? CRechnungsadressePostId { get; set; }

    public string? CRechnungsadresseBundesland { get; set; }

    public string? CRechnungsadresseLandIso { get; set; }

    public string CRechnungsadresseKundennummer { get; set; } = null!;

    public string? CRechnungsadresseZuHaenden { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public string? CLieferadresseTitel { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseMobiltelefonnummer { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseZusatzinformationen { get; set; }

    public string? CLieferadressePostId { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseLandIso { get; set; }

    public decimal FAuftragswert { get; set; }

    public decimal FGutgeschriebenerWert { get; set; }

    public decimal FBereitsgezahltWert { get; set; }

    public decimal? FOffenerWert { get; set; }

    public string? CSonstiges { get; set; }

    public string CIstBezahlt { get; set; } = null!;

    public string CExistiertRechnung { get; set; } = null!;

    public int NKomplettgeliefert { get; set; }

    public int NLieferstatus { get; set; }

    public byte? NWmsgesperrt { get; set; }

    public int? NWmsteillieferung { get; set; }

    public int? NWmsvorkommissionieren { get; set; }

    public byte? NMahnstufe { get; set; }

    public decimal? FAuftragswertVersandland { get; set; }

    public decimal? FMahnGebuehr { get; set; }

    public int? NAnzahlRetouren { get; set; }
}
