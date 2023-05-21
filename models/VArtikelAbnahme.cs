using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelAbnahme
{
    public int KArtikel { get; set; }

    public int KKundengruppe { get; set; }

    public decimal FMindestabnahme { get; set; }

    public decimal FIntervall { get; set; }
}
