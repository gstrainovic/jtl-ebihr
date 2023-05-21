using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvRechnungsposition
{
    public int KRechnung { get; set; }

    public int KRechnungPosition { get; set; }

    public int? KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CEinheit { get; set; }

    public string? CArtNr { get; set; }

    public string? CHinweis { get; set; }

    public decimal FMwSt { get; set; }

    public decimal FAnzahl { get; set; }

    public int NSort { get; set; }

    public decimal FBruttoPreisEinzeln { get; set; }

    public decimal FNettoPreisEinzeln { get; set; }

    public decimal FBruttoPreisGesamt { get; set; }

    public decimal FNettoPreisGesamt { get; set; }

    public decimal FMwStBetrag { get; set; }

    public decimal FRabattvertrag { get; set; }

    public decimal FRabattProzent { get; set; }

    public int? KRechnungStueckliste { get; set; }

    public int? KKonfigVater { get; set; }

    public int? KAuftrag { get; set; }

    public int? KAuftragPosition { get; set; }

    public decimal? FGewichtEinzeln { get; set; }

    public decimal? FGewichtGesamt { get; set; }

    public decimal? FVersandgewichtEinzeln { get; set; }

    public decimal? FVersandgewichtGesamt { get; set; }

    public bool NArchiv { get; set; }

    public int? KPlattform { get; set; }

    public string? CAuftragsnummer { get; set; }

    public int? KShopauftrag { get; set; }

    public DateTime? DVoraussichtlichesLieferdatum { get; set; }

    public string? CErloeskonto { get; set; }

    public DateTime? DZahlungsmaildatum { get; set; }

    public byte NBeschreibung { get; set; }

    public int NInet { get; set; }

    public string? CExterneAuftragsnummer { get; set; }

    public string? CStatustext { get; set; }

    public string? CeBayVerwendungszweck { get; set; }

    public bool NStorniert { get; set; }

    public string? CZahlungsmodulId { get; set; }

    public decimal FZusatzgewicht { get; set; }

    public decimal FGutgeschriebenerWert { get; set; }

    public decimal FBereitsgezahltWert { get; set; }

    public int NKomplettgeliefert { get; set; }

    public byte NIstReadOnly { get; set; }
}
