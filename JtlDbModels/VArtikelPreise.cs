using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelPreise
{
    public int KPreis { get; set; }

    public int KArtikel { get; set; }

    public int KKundenGruppe { get; set; }

    public int KShop { get; set; }

    public int KKunde { get; set; }

    public int? KInetKunde { get; set; }
}
