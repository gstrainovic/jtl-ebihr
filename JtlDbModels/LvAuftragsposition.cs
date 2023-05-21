using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAuftragsposition
{
    public int KAuftrag { get; set; }

    public byte NAuftragStatus { get; set; }

    public int KAuftragPosition { get; set; }

    public decimal? FAnzRetoure { get; set; }

    public int? KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CArtNr { get; set; }

    public string? CHinweis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal? FVknettoGesamt { get; set; }

    public decimal? FGeliefert { get; set; }

    public decimal? FGutgeschrieben { get; set; }

    public decimal FVkNetto { get; set; }

    public decimal FMwSt { get; set; }

    public decimal? FVkbrutto { get; set; }

    public decimal? FVerfuegbar { get; set; }

    public decimal? FLagerbestand { get; set; }

    public decimal? FVerfuegbarGesperrt { get; set; }

    public decimal? FAuslieferungGesperrt { get; set; }

    public decimal? FZulauf { get; set; }

    public decimal? FAufEinkaufsliste { get; set; }

    public int NSort { get; set; }

    public byte? NLagerAktiv { get; set; }

    public int? KStuecklistenVater { get; set; }

    public int? KKonfigurationsVater { get; set; }

    public string? CErloeskonto { get; set; }

    public decimal? NAnzahlFehlbestandEigen { get; set; }

    public int NLieferbarStatus { get; set; }

    public int NLieferbarStatusEigen { get; set; }

    public decimal FAufRechnung { get; set; }

    public decimal FLagerbestandEigen { get; set; }

    public decimal FOffeneAuftragsmenge { get; set; }

    public decimal FFehlbestand { get; set; }

    public decimal FFehlbestandEigen { get; set; }
}
