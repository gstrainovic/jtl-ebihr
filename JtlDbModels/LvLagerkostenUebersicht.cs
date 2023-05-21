using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvLagerkostenUebersicht
{
    public long? NRegel { get; set; }

    public int? KAbrechnungLagerplatz { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int KWarenlager { get; set; }

    public int? KLieferant { get; set; }

    public int? KArtikel { get; set; }

    public int? KArtikelIndividuell { get; set; }

    public string? CArtNr { get; set; }

    public string? CArtNrIndividuell { get; set; }

    public int? NModus { get; set; }

    public int? NLagerkostenBerechnung { get; set; }

    public decimal FLaenge { get; set; }

    public decimal FBreite { get; set; }

    public decimal FHoehe { get; set; }

    public decimal? FVkpreis { get; set; }

    public int? NSort { get; set; }

    public string? CName { get; set; }

    public int? KWarenLagerPlatzTyp { get; set; }

    public string? CSessionId { get; set; }
}
