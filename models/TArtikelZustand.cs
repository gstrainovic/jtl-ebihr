using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelZustand
{
    public int KArtikelZustand { get; set; }

    public int KHauptartikel { get; set; }

    public int KZustandArtikel { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
