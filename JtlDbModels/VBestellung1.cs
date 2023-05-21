using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestellung1
{
    public int KBestellung { get; set; }

    public int? TRechnungKRechnung { get; set; }

    public int TBenutzerKBenutzer { get; set; }

    public int? TAdresseKAdresse { get; set; }

    public int TTextKText { get; set; }

    public int TKundeKKunde { get; set; }

    public string CBestellNr { get; set; } = null!;

    public string? CType { get; set; }

    public string? CAnmerkung { get; set; }

    public DateTime? DErstellt { get; set; }

    public int? NZahlungsZiel { get; set; }

    public int? TVersandArtKVersandArt { get; set; }

    public decimal FVersandBruttoPreis { get; set; }

    public decimal FRabatt { get; set; }

    public int? KInetBestellung { get; set; }

    public string? CVersandInfo { get; set; }

    public DateTime? DVersandt { get; set; }

    public string? CIdentCode { get; set; }

    public string? CBeschreibung { get; set; }

    public string? CInet { get; set; }

    public DateTime? DLieferdatum { get; set; }

    public int? KBestellHinweis { get; set; }

    public string CErloeskonto { get; set; } = null!;

    public string? CWaehrung { get; set; }

    public decimal FFaktor { get; set; }

    public int? KShop { get; set; }

    public int KFirma { get; set; }

    public int? KLogistik { get; set; }

    public int NPlatform { get; set; }

    public int KSprache { get; set; }

    public decimal FGutschein { get; set; }

    public DateTime? DGedruckt { get; set; }

    public DateTime? DMailVersandt { get; set; }

    public string? CInetBestellNr { get; set; }

    public int? KZahlungsart { get; set; }

    public int? KLieferadresse { get; set; }

    public int? KRechnungsadresse { get; set; }

    public byte? NIgl { get; set; }

    public byte? NUstFrei { get; set; }

    public string? CStatus { get; set; }

    public DateTime? DVersandMail { get; set; }

    public DateTime? DZahlungsMail { get; set; }

    public string? CUserName { get; set; }

    public string CVerwendungszweck { get; set; } = null!;

    public decimal FSkonto { get; set; }

    public int? KColor { get; set; }

    public byte? NStorno { get; set; }

    public string? CModulId { get; set; }

    public int? NZahlungstyp { get; set; }

    public int? NHatUpload { get; set; }

    public decimal FZusatzGewicht { get; set; }

    public byte NKomplettAusgeliefert { get; set; }

    public DateTime? DBezahlt { get; set; }

    public int? KSplitBestellung { get; set; }

    public string? CPuiZahlungsdaten { get; set; }

    public int? NPrio { get; set; }

    public string CVersandlandIso { get; set; } = null!;

    public string CUstId { get; set; } = null!;

    public byte NPremium { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungFaktor { get; set; }

    public int KRueckhaltegrund { get; set; }

    public string? COutboundId { get; set; }

    public int? KFulfillmentLieferant { get; set; }

    public string? CKundenauftragsnummer { get; set; }

    public bool? NIstReadOnly { get; set; }

    public string? CAmazonServiceLevel { get; set; }

    public bool? NIstExterneRechnung { get; set; }

    public string? CKampagne { get; set; }

    public string? CKampagneParam { get; set; }

    public string? CKampagneName { get; set; }

    public string? CUserAgent { get; set; }

    public string? CReferrer { get; set; }

    public int? NMaxLiefertage { get; set; }

    public int? KAmazonUser { get; set; }
}
