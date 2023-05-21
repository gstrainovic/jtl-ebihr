using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class LvAbonnement
{
    public int KKunde { get; set; }

    public int KBestellung { get; set; }

    public string CBestellNr { get; set; } = null!;

    public int? NZahlungsziel { get; set; }

    public decimal? FWert { get; set; }

    public decimal? FZahlung { get; set; }

    public decimal? FGutschrift { get; set; }

    public decimal FFaktor { get; set; }

    public string? CWaehrung { get; set; }

    public DateTime? DStartdatum { get; set; }

    public DateTime? DEnddatum { get; set; }

    public DateTime? DNextFaelligkeit { get; set; }

    public string? Zahlungsart { get; set; }
}
