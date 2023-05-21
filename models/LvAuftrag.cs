using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvAuftrag
{
    public int KBestellung { get; set; }

    public int KFirma { get; set; }

    public int KKunde { get; set; }

    public int? KInetBestellung { get; set; }

    public DateTime DErstellt { get; set; }

    public string CBestellnr { get; set; } = null!;

    public string? CAnmerkung { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DMailVersandt { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public DateTime? DVoraussichtlicheLieferung { get; set; }

    public string? CInetBestellnr { get; set; }

    public string? CStatus { get; set; }

    public int NPlattform { get; set; }

    public int? KColor { get; set; }

    public int? KZahlungsart { get; set; }

    public string? CWaehrungIso { get; set; }

    public string? CAmazonServiceLevel { get; set; }

    public int? NVersandstatus { get; set; }

    public int? NVersandstatusEigen { get; set; }

    public int NIstDropshipping { get; set; }

    public int NIstBezahlt { get; set; }

    public int KWarenlager { get; set; }

    public string? CFirmaName { get; set; }

    public string? CSpracheName { get; set; }

    public string? CLieferadresseTitel { get; set; }

    public string? CLieferadresseFirma { get; set; }

    public string? CLieferadresseVorname { get; set; }

    public string? CLieferadresseNachname { get; set; }

    public string? CLieferadresseZusatz { get; set; }

    public string? CLieferadresseStrasse { get; set; }

    public string? CLieferadressePlz { get; set; }

    public string? CLieferadresseOrt { get; set; }

    public string? CLieferadresseLand { get; set; }

    public string? CLieferadresseBundesland { get; set; }

    public string? CLieferadresseMail { get; set; }

    public string? CLieferadresseTelefon { get; set; }

    public string? CLieferadresseFax { get; set; }

    public string? CLieferadresseAnrede { get; set; }

    public string? CLieferadresseAdressZusatz { get; set; }

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

    public string? CKundeNr { get; set; }

    public string CBenutzername { get; set; } = null!;

    public decimal FWert { get; set; }

    public decimal FZahlung { get; set; }

    public decimal FGutschriftWert { get; set; }

    public string? CVersandartName { get; set; }

    public string? CShopName { get; set; }

    public string? CBestellhinweis { get; set; }

    public string CPlattformName { get; set; } = null!;

    public int NPickstatus { get; set; }

    public int NIstWmsteillieferungErlaubt { get; set; }

    public int NWmsvorkommissionieren { get; set; }

    public byte NIstWmsgesperrt { get; set; }

    public byte NZahlungsstatus { get; set; }

    public decimal? FArtikelgewicht { get; set; }

    public decimal? FArtikelversandgewicht { get; set; }

    public int NAuftragsprioritaet { get; set; }

    public decimal FAnzahlGepickt { get; set; }

    public string? CZahlungsart { get; set; }

    public int? KVersandart { get; set; }

    public int KRueckhalteGrund { get; set; }

    public string? CRueckhalteGrund { get; set; }

    public int NPickZustand { get; set; }

    public byte NAuftragStatus { get; set; }

    public string? CRechnungsnummern { get; set; }
}
