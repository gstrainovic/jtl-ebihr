using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VArtikelEigenschaftKombiWert
{
    public int KEigenschaftKombi { get; set; }

    public int KEigenschaft { get; set; }

    public int? KEigenschaftWert { get; set; }

    public int KArtikel { get; set; }

    public int KVaterArtikel { get; set; }

    public int KShop { get; set; }
}
