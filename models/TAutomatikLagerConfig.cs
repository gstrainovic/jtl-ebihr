using System;
using System.Collections.Generic;

namespace jtl_ebihr;

public partial class TAutomatikLagerConfig
{
    public int KAutomatikLagerConfig { get; set; }

    public int KWarenlager { get; set; }

    public string CUrl { get; set; } = null!;

    public string CName { get; set; } = null!;

    public int NTyp { get; set; }

    public byte[] BRowversion { get; set; } = null!;

    public byte NAutostoreContentValuation { get; set; }
}
