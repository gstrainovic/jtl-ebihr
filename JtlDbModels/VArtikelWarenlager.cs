using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelWarenlager
{
    public int KArtikel { get; set; }

    public int KWarenlager { get; set; }

    public decimal? FBestand { get; set; }
}
