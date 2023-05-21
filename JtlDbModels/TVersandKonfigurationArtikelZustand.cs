using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TVersandKonfigurationArtikelZustand
{
    public int KVersandKonfiguration { get; set; }

    public int KZustand { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
