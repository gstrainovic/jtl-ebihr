using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvArtikelVerkaeufe
{
    public int KArtikel { get; set; }

    public string CArtNr { get; set; } = null!;

    public string? CEan { get; set; }

    public string? CArtikelName { get; set; }

    public decimal? MengeKaeufe { get; set; }

    public int? AnzahlKaeufe { get; set; }

    public decimal? GesamtWert { get; set; }

    public decimal FVknetto { get; set; }

    public decimal? VerkaufspreisBrutto { get; set; }

    public decimal? AvgVkPreis { get; set; }

    public DateTime? LetzterKauf { get; set; }

    public int KKunde { get; set; }
}
