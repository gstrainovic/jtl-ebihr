using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TVoucherCloudLogeintrag
{
    public int KVoucherCloudLogeintrag { get; set; }

    public DateTime DZeitpunkt { get; set; }

    public byte NSchweregrad { get; set; }

    public int? KShop { get; set; }

    public string? CMeldung { get; set; }
}
