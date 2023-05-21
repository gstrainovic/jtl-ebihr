using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelAttributSprachePlattform
{
    public int KAttribut { get; set; }

    public int KArtikel { get; set; }

    public int KShop { get; set; }

    public int? KArtikelAttribut { get; set; }
}
