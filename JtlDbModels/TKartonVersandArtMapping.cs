using System;
using System.Collections.Generic;

namespace JtlDbModels;

public partial class TKartonVersandArtMapping
{
    public int KVersandArt { get; set; }

    public int KArtikel { get; set; }

    public byte NIstStandard { get; set; }
}
