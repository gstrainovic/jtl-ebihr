using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VInventur
{
    public int KArtikel { get; set; }

    public decimal? FBestand { get; set; }

    public int KWarenlager { get; set; }
}
