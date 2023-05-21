using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TFormularAnhangDaten
{
    public int KFormularAnhangDaten { get; set; }

    public string CDateiname { get; set; } = null!;

    public byte[] BSha1 { get; set; } = null!;

    public byte[] BDaten { get; set; } = null!;

    public byte[] BRowversion { get; set; } = null!;
}
