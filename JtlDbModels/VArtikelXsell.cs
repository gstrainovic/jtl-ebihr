using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelXsell
{
    public int KXsell { get; set; }

    public int KXsellArtikel { get; set; }

    public int? KXsellGruppe { get; set; }

    public int KArtikel { get; set; }
}
