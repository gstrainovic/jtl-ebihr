using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVersandKonfigurationArtikelZustand
{
    public int KVersandKonfiguration { get; set; }

    public int KZustand { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
