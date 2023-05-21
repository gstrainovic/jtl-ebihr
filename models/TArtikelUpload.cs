using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelUpload
{
    public int KArtikelUpload { get; set; }

    public int? KArtikel { get; set; }

    public string? CDateiTyp { get; set; }

    public int? NPflicht { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
