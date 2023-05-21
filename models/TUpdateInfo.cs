using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TUpdateInfo
{
    public int KUpdateInfo { get; set; }

    public byte NVorgang { get; set; }

    public string CKey { get; set; } = null!;

    public string? CValueOld { get; set; }

    public string? CValueNew { get; set; }

    public byte[] BRowversion { get; set; } = null!;
}
