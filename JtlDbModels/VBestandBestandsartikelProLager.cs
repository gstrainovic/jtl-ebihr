using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestandBestandsartikelProLager
{
    public int KArtikel { get; set; }

    public int KWarenLager { get; set; }

    public decimal? FBestand { get; set; }

    public decimal? FBestandGesperrtFuerVerfuegbar { get; set; }

    public decimal? FBestandGesperrtFuerAuslieferung { get; set; }
}
