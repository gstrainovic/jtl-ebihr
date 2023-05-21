using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TArtikelLagerOrt
{
    public int KArtikelLagerOrt { get; set; }

    public int? KLager { get; set; }

    public int? KLagerOrt { get; set; }

    public int? KArtikel { get; set; }

    public string? CKommentar { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
