using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VStandardAuftragCache
{
    public int KAuftrag { get; set; }

    public byte NAuftragStatus { get; set; }

    public int KBenutzer { get; set; }

    public int? KKunde { get; set; }

    public int? KKundengruppe { get; set; }

    public int? KInetBestellung { get; set; }

    public int KBestellhinweis { get; set; }

    public int? KPlattform { get; set; }

    public int KFirmaHistory { get; set; }

    public int? KRueckhalteGrund { get; set; }

    public int KSprache { get; set; }

    public int? KShop { get; set; }

    public int? KVersandart { get; set; }

    public int? KZahlungsart { get; set; }

    public int? KFarbe { get; set; }

    public int? KVorgangsstatus { get; set; }

    public string CAuftragsnummer { get; set; } = null!;

    public string? CExterneAuftragsnummer { get; set; }

    public string? CWaehrung { get; set; }

    public decimal FWaehrungsfaktor { get; set; }

    public int? NSteuereinstellung { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public DateTime DErstellt { get; set; }

    public int? NZahlungszielTage { get; set; }

    public int NKomplettAusgeliefert { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public int NLieferprioritaet { get; set; }

    public byte NBeschreibung { get; set; }

    public string? CVersandlandIso { get; set; }

    public string CVersandlandWaehrung { get; set; } = null!;

    public decimal FVersandlandWaehrungFaktor { get; set; }

    public int NInet { get; set; }

    public byte NIstReadOnly { get; set; }

    public byte NIstExterneRechnung { get; set; }

    public string? CZahlungsmodulId { get; set; }

    public string? CeBayBenutzername { get; set; }

    public byte? NStorniert { get; set; }

    public int NInnergemeinschaftlicheLieferung { get; set; }

    public int NUmsatzsteuerfrei { get; set; }

    public int NPlattformTyp { get; set; }

    public decimal FGutgeschriebenerWert { get; set; }

    public decimal FBereitsgezahltWert { get; set; }

    public DateTime? DDruckdatum { get; set; }

    public DateTime? DMaildatum { get; set; }

    public DateTime? DZahlungsmaildatum { get; set; }

    public DateTime? DBezahlt { get; set; }

    public DateTime? DLetzterVersand { get; set; }

    public byte NRechnungStatus { get; set; }

    public byte NZahlungStatus { get; set; }

    public int NAnzahlPakete { get; set; }

    public int NAnzahlVersendetePakete { get; set; }

    public decimal FGutschrift { get; set; }

    public decimal FAuftragswertBrutto { get; set; }

    public decimal FAuftragswertNetto { get; set; }

    public decimal FOffenerWert { get; set; }

    public decimal? FAuftragswertVersandland { get; set; }

    public string? CKundenNr { get; set; }

    public int? NDebitorennr { get; set; }

    public string? CRechnungsnummern { get; set; }

    public bool NPending { get; set; }
}
