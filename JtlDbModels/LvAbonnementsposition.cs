using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAbonnementsposition
{
    public int KAuftrag { get; set; }

    public int KAuftragPosition { get; set; }

    public int? KArtikel { get; set; }

    public string? CName { get; set; }

    public string? CArtNr { get; set; }

    public string? CHinweis { get; set; }

    public decimal FAnzahl { get; set; }

    public decimal? FVknettoGesamt { get; set; }

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

    public int NIstFaellig { get; set; }

    public int? NTyp { get; set; }

    public int? NIntervall { get; set; }

    public int? NIntervallTyp { get; set; }

    public DateTime? DNextFaelligkeit { get; set; }
}
