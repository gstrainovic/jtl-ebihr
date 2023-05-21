using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class VLagerbestandProLager1
{
    public string CArtNr { get; set; } = null!;

    public string? DatensätzeFehlen { get; set; }

    public string? Bestände { get; set; }

    public string? CodeZumKorigieren { get; set; }

    public int KWarenLager { get; set; }

    public int KArtikel { get; set; }
}
