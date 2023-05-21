using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VBestandVirtuell
{
    public int KArtikel { get; set; }

    public decimal? FBestand { get; set; }

    public decimal? FZulauf { get; set; }
}
