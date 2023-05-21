using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TWarenLagerPlatzArtikel
{
    public int KWarenLagerPlatz { get; set; }

    public int KArtikel { get; set; }

    public string? CKommentar1 { get; set; }

    public string? CKommentar2 { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
