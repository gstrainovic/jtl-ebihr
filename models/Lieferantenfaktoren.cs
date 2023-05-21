using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class Lieferantenfaktoren
{
    public int KArtikel { get; set; }

    public int KLieferant { get; set; }

    public string? CFirma { get; set; }

    public decimal? Faktor { get; set; }
}
