using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class VArtikelPreisDetail
{
    public int KPreis { get; set; }

    public int NAnzahlAb { get; set; }

    public decimal FNettoPreis { get; set; }

    public decimal FProzent { get; set; }

    public int KShop { get; set; }

    public int KArtikel { get; set; }
}
