using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TAbrechnungLagerplatzPreview
{
    public int KAbrechnungLagerplatz { get; set; }

    public int KLieferant { get; set; }

    public int KWarenLagerPlatz { get; set; }

    public int KWarenLagerPlatzTyp { get; set; }

    public int KWmslagerBereich { get; set; }

    public int KWarenlager { get; set; }

    public int NModus { get; set; }

    public int NLagerkostenBerechnung { get; set; }

    public int KArtikel { get; set; }

    public int KBenutzer { get; set; }

    public string CSessionId { get; set; } = null!;

    public DateTime DZeitstempel { get; set; }
}
