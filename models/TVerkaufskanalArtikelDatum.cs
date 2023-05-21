using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVerkaufskanalArtikelDatum
{
    public int KVerkaufskanalArtikelData { get; set; }

    public int KArtikel { get; set; }

    public int KShopScx { get; set; }

    public int? KCategory { get; set; }

    public decimal NMaximalerBestand { get; set; }

    public decimal NMindestbestand { get; set; }

    public virtual TArtikel KArtikelNavigation { get; set; } = null!;

    public virtual TShopScx KShopScxNavigation { get; set; } = null!;
}
