using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class LvLagerkostenRegeln
{
    public long? NRegel { get; set; }

    public int KAbrechnungLagerplatz { get; set; }

    public int KLieferant { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int KWarenLagerPlatzTyp { get; set; }

    public int KWmslagerBereich { get; set; }

    public int KWarenlager { get; set; }

    public int NModus { get; set; }

    public int NLagerkostenBerechnung { get; set; }

    public int KArtikel { get; set; }

    public string? CArtNr { get; set; }

    public string? CArtikelname { get; set; }

    public string? CBereich { get; set; }

    public string CSessionId { get; set; } = null!;

    public decimal? FVkpreis { get; set; }

    public string? CWarenLagerPlatzName { get; set; }
}
