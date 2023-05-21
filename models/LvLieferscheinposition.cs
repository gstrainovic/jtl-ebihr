using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvLieferscheinposition
{
    public int KLieferschein { get; set; }

    public int KLieferscheinPos { get; set; }

    public int KBestellPos { get; set; }

    public string? CArtNr { get; set; }

    public string? CName { get; set; }

    public decimal FMenge { get; set; }

    public string? CHinweis { get; set; }

    public int KStuecklistenVater { get; set; }

    public int? KKonfigurationsVater { get; set; }

    public int KArtikel { get; set; }

    public decimal? FVerfuegbarGesperrt { get; set; }

    public decimal FMengeRechnung { get; set; }
}
